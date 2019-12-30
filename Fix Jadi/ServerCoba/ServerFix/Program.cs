using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

[Serializable]
public class randomFruit
{
    public float fruit1;
    public float fruit2;
    public float fruit3;
}

[Serializable]
public class fruit1
{
    public float positX1;
    public float positY1;
    public float positZ1;

    public float positX2;
    public float positY2;
    public float positZ2;
}

[Serializable]
public class fruit2
{
    public float positX1;
    public float positY1;
    public float positZ1;

    public float positX2;
    public float positY2;
    public float positZ2;
}

public static class data
{
    public static string usernamePlayer1;
    public static string usernamePlayer2;
    public static int characterPlayer1 = 1;
    public static int characterPlayer2 = 1;
    public static string player1Data;
    public static string player2Data;
    public static string fruit1Data;
    public static string fruit2Data;
}

public static class counter
{
    public static float time;
    public static int match = 1;
    public static int jumlahClient = 0;
    public static string password;
    public static string sendFile;
}

public class Server
{
    public static TcpClient client;

    private static void sendClient()
    {
        StreamWriter w = new StreamWriter(client.GetStream());
        StreamReader r = new StreamReader(client.GetStream());
        Console.WriteLine(" masuk");

        while (true)
        {
            w.WriteLine(Convert.ToString(counter.jumlahClient));
            w.Flush();
        }
    }

    private static void PlayerController(object argument)
    {
        client = (TcpClient)argument;
        int urutan = counter.jumlahClient;

        try
        {
            StreamReader reader = new StreamReader(client.GetStream());
            StreamWriter writer = new StreamWriter(client.GetStream());

            string receive = reader.ReadLine();
            string pass = reader.ReadLine();

            receive = StringCipher.Decrypt(receive, pass);

            if (urutan == 1)
            {
                data.usernamePlayer1 = receive;
                data.characterPlayer1 = Int32.Parse(reader.ReadLine());

                Console.WriteLine(" P1 || " + data.usernamePlayer1 + " || char-" + data.characterPlayer1);
                receive = string.Empty;

                writer.WriteLine(Convert.ToString(urutan));
                writer.Flush();

                Thread Client = new Thread(sendClient);
                Client.Start();
            }
            else if (receive == data.usernamePlayer1)
            {
                Console.WriteLine(" " + data.usernamePlayer1 + " || ready to receive");
            }
            else if (urutan == 2)
            {
                data.usernamePlayer2 = receive;
                data.characterPlayer2 = Int32.Parse(reader.ReadLine());

                Console.WriteLine(" P2 || " + data.usernamePlayer2 + " || char-" + data.characterPlayer2);
                receive = string.Empty;

                writer.WriteLine(Convert.ToString(urutan));
                writer.Flush();

                Thread Client = new Thread(sendClient);
                Client.Start();
            }
            else if (receive == data.usernamePlayer2)
            {
                Console.WriteLine(" " + data.usernamePlayer2 + " || ready to receive");
            }

            while (true)
            {
                if (urutan == 1)
                {
                    data.player1Data = reader.ReadLine();
                }
                else if (receive == data.usernamePlayer1)
                {
                    writer.WriteLine(Convert.ToString(data.characterPlayer2));
                    writer.Flush();

                    writer.WriteLine(data.player2Data);
                    writer.Flush();

                    writer.WriteLine(Convert.ToString(counter.time));
                    writer.Flush();
                }
                else if (urutan == 2)
                {
                    data.player2Data = reader.ReadLine();
                }
                else if (receive == data.usernamePlayer2)
                {
                    writer.WriteLine(Convert.ToString(data.characterPlayer1));
                    writer.Flush();

                    writer.WriteLine(data.player1Data);
                    writer.Flush();

                    writer.WriteLine(Convert.ToString(counter.time));
                    writer.Flush();
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("\n [Ada Client Keluar...]");
        }
        if (client != null)
        {
            client.Close();
        }
    }

    public static void timer()
    {
        counter.time = 35f;
        while (counter.match != 0)
        {
            counter.time -= 1;
            Console.Write(" " + counter.time);
            Thread.Sleep(1500);

            if (counter.time == 0)
            {
                Console.WriteLine();
                counter.time = 35f;
                counter.match--;
            }
        }
        counter.time = -1;
    }

    public static void Main()
    {
        TcpListener listener = null;

        try
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), 8080);
            listener.Start();

            Console.WriteLine(" [Mulai...]");

            while (counter.jumlahClient < 4)
            {
                client = listener.AcceptTcpClient();
                Thread newThread = new Thread(PlayerController);
                newThread.Start(client);
                counter.jumlahClient++;
            }

            Thread time = new Thread(timer);
            time.Start();
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

    public static class StringCipher
    {
        private const int Keysize = 256;
        private const int DerivationIterations = 1000;

        public static string Encrypt(string plainText, string passPhrase)
        {
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }
        public static string Decrypt(string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }
        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}