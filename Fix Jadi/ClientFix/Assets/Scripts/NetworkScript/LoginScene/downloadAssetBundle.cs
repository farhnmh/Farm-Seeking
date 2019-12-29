using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;

public class downloadAssetBundle : MonoBehaviour
{
    public bool downloaded = false;

    public void Main()
    {
        try
        {
            Debug.Log("open");
            TcpClient client = new TcpClient("127.0.0.1", 8080);
            Debug.Log("Connected to Server");

            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());

            string pass = reader.ReadLine();
            string fileName = reader.ReadLine();
            string cmdFileSize = reader.ReadLine();
            string cmdFileName = reader.ReadLine();

            int length = Convert.ToInt32(cmdFileSize);
            byte[] buffer = new byte[length];
            int received = 0;
            int read = 0;
            int size = 1024;
            int remaining = 0;

            while (received < length)
            {
                remaining = length - received;
                if (remaining < size)
                {
                    size = remaining;
                }

                read = client.GetStream().Read(buffer, received, size);
                received += read;
            }

            using (FileStream fStream = new FileStream(Path.GetFileName(cmdFileName), FileMode.Create))
            {
                fStream.Write(buffer, 0, buffer.Length);
                fStream.Flush();
                fStream.Close();
            }

            Debug.Log("File received and saved in " + Environment.CurrentDirectory);

            int unicode = 92;
            char character = (char)unicode;
            string text = character.ToString();

            string zipPath = Environment.CurrentDirectory + text + fileName;
            string startFilePath = zipPath;
            Debug.Log(zipPath);

            string endFilePath = @".\Assets.zip";
            string extractPath = @".\AssetsReceived";
            DecryptFile(startFilePath, endFilePath, pass);

            Debug.Log("File decrypted successfully with pass : " + pass);
            Debug.Log("File extracted successfully in " + extractPath);
            //ZipFile.ExtractToDirectory(endFilePath, extractPath);
            downloaded = true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
    {
        byte[] decryptedBytes = null;
        byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

        using (MemoryStream ms = new MemoryStream())
        {
            using (RijndaelManaged AES = new RijndaelManaged())
            {
                AES.KeySize = 256;
                AES.BlockSize = 128;

                var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                AES.Key = key.GetBytes(AES.KeySize / 8);
                AES.IV = key.GetBytes(AES.BlockSize / 8);

                AES.Mode = CipherMode.CBC;

                using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                    cs.Close();
                }
                decryptedBytes = ms.ToArray();
            }
        }

        return decryptedBytes;
    }
    public static void DecryptFile(string fileEncrypted, string file, string password)
    {
        byte[] bytesToBeDecrypted = File.ReadAllBytes(fileEncrypted);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

        File.WriteAllBytes(file, bytesDecrypted);
    }
}