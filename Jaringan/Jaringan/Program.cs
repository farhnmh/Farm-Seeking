<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;

struct data
{
    public string namePlayer;
    public float xPlayer;
    public float yPlayer;
    public float zPlayer;
}

public static class counter
{
    public static int numPlayer = 0;
}

public class Server
{
    public static void encryptCompress()
    {
        string startPath = @"Z:\Assets";
        string zipPath = @"Z:\Assets.zip";

        Console.Write(" [Input your file directory for compress] ");
        startPath = Console.ReadLine();
        zipPath = startPath + ".zip";

        ZipFile.CreateFromDirectory(startPath, zipPath);
        Console.WriteLine(" [The file compressed successfully]");

        string startFilePath = zipPath;
        string endFilePath = @"Z:\Assets-enc";
        string sendFile = endFilePath;

        endFilePath = startPath + "-enc";

        Random rnd = new Random();
        int pass = rnd.Next();
        string secretKey = pass.ToString();

        EncryptFile(startFilePath, endFilePath, secretKey);
        Console.WriteLine(" [The file encrypted successfully with pass : " + secretKey + "]");
    }

    private static void FarmSeek(object argument)
    {
        data[] player = new data[2];
        int ke = counter.numPlayer;

        TcpClient client = (TcpClient)argument;

        try
        {
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());

            if (ke == 1) {
                Console.WriteLine(" [" + ke + "st joined}");
            }
            if (ke == 2)
            {
                Console.WriteLine(" [" + ke + "nd joined}");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("\n [There's Client Out...]");
        }
        if (client != null)
        {
            client.Close();
        }
    }

    public static void Main()
    {
        TcpListener listener = null;
        encryptCompress();

        try
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();

            Console.WriteLine(" [Starting...]");

            while (counter.numPlayer <= 2)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine(" [There's Client Join...]");
                Thread newThread = new Thread(FarmSeek);

                counter.numPlayer++;
                newThread.Start(client);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        finally
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }

    public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
    {
        byte[] encryptedBytes = null;
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

                using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    cs.Close();
                }
                encryptedBytes = ms.ToArray();
            }
        }

        return encryptedBytes;
    }
    public static void EncryptFile(string file, string fileEncrypted, string password)
    {
        byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

        File.WriteAllBytes(fileEncrypted, bytesEncrypted);
    }
=======
﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Security;
using System.Security.Cryptography;
using System.Runtime.InteropServices;
using System.Linq;
using System.Threading.Tasks;

struct data
{
    public string namePlayer;
    public float xPlayer;
    public float yPlayer;
    public float zPlayer;
}

public static class counter
{
    public static int numPlayer = 0;
}

public class Server
{
    public static void encryptCompress()
    {
        string startPath = @"Z:\Assets";
        string zipPath = @"Z:\Assets.zip";

        Console.Write(" [Input your file directory for compress] ");
        startPath = Console.ReadLine();
        zipPath = startPath + ".zip";

        ZipFile.CreateFromDirectory(startPath, zipPath);
        Console.WriteLine(" [The file compressed successfully]");

        string startFilePath = zipPath;
        string endFilePath = @"Z:\Assets-enc";
        string sendFile = endFilePath;

        endFilePath = startPath + "-enc";

        Random rnd = new Random();
        int pass = rnd.Next();
        string secretKey = pass.ToString();

        EncryptFile(startFilePath, endFilePath, secretKey);
        Console.WriteLine(" [The file encrypted successfully with pass : " + secretKey + "]");
    }

    private static void FarmSeek(object argument)
    {
        data[] player = new data[2];
        int ke = counter.numPlayer;

        TcpClient client = (TcpClient)argument;

        try
        {
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());

            if (ke == 1) {
                Console.WriteLine(" [" + ke + "st joined}");
            }
            if (ke == 2)
            {
                Console.WriteLine(" [" + ke + "nd joined}");
            }
        }
        catch (IOException)
        {
            Console.WriteLine("\n [There's Client Out...]");
        }
        if (client != null)
        {
            client.Close();
        }
    }

    public static void Main()
    {
        TcpListener listener = null;
        encryptCompress();

        try
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();

            Console.WriteLine(" [Starting...]");

            while (counter.numPlayer <= 2)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine(" [There's Client Join...]");
                Thread newThread = new Thread(FarmSeek);

                counter.numPlayer++;
                newThread.Start(client);
            }
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }

        finally
        {
            if (listener != null)
            {
                listener.Stop();
            }
        }
    }

    public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
    {
        byte[] encryptedBytes = null;
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

                using (var cs = new CryptoStream(ms, AES.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
                    cs.Close();
                }
                encryptedBytes = ms.ToArray();
            }
        }

        return encryptedBytes;
    }
    public static void EncryptFile(string file, string fileEncrypted, string password)
    {
        byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
        byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

        passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

        byte[] bytesEncrypted = AES_Encrypt(bytesToBeEncrypted, passwordBytes);

        File.WriteAllBytes(fileEncrypted, bytesEncrypted);
    }
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
}