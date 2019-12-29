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
}