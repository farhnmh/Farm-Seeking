using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System;
using System.IO;

public class Client : MonoBehaviour
{
    public string clientName;
    public bool isHost;

    private bool socketReady;
    private TcpClient socket;
    private NetworkStream stream;
    private StreamWriter writer;
    private StreamReader reader;

    private List<GameClient> players = new List<GameClient>();

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public bool ConnectToServer(string host, int port)
    {
        if (socketReady)
        {
            return false;
        }
            

        try
        {
            socket = new TcpClient(host, port);
            stream = socket.GetStream();
            writer = new StreamWriter(stream);
            reader = new StreamReader(stream);

            socketReady = true;

        } catch (Exception e)
        {
            Debug.Log("Socket Error : " + e.Message);
        }

        return socketReady;
    }

    private void Update()
    {
        if(socketReady)
        {
            if(stream.DataAvailable)
            {
                string data = reader.ReadLine();
                if(data != null)
                {
                    OnIncomingData(data);
                }
            }
        }
    }

    //Sending messages to server
    public void Send(string data)
    {
        if (!socketReady)
            return;

        writer.WriteLine(data);
        writer.Flush();
    }

    //Read messages from the server
    private void OnIncomingData(string data)
    {
        Debug.Log("Client : " + data);
        string[] aData = data.Split('|');

        switch (aData[0])
        {
            case "SWHO":
                for (int i = 1; i < aData.Length - 1; i++)
                {
                    UserConnected(aData[i], false);
                }
                Send("CWHO|" + clientName + "|" + ((isHost)? 1:0).ToString());
                break;

            case "SCNN":
                UserConnected(aData[1], false);
                break;

            case "SSPAWN":
                int x = 0;
                Int32.TryParse(aData[1], out x);
                SpawnFruitCards.Instance.serverSpawn = x;
                break;

            case "SFRUITS":
                int y = 0;
                Int32.TryParse(aData[1], out y);
                SpawnFruits.Instance.serverFruits = y;
                break;

            //Player 1
            case "SMAJUP1":
                Player.Instance.Maju(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SBALIKP1":
                Player.Instance.Balik(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUNDURP1":
                Player.Instance.Mundur(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUTERKANANP1":
                Player.Instance.MuterKanan(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUTERKIRIP1":
                Player.Instance.MuterKiri(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;

            case "SMAJUP2":
                Player2.Instance.Maju(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SBALIKP2":
                Player2.Instance.Balik(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUNDURP2":
                Player2.Instance.Mundur(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUTERKANANP2":
                Player2.Instance.MuterKanan(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;
            case "SMUTERKIRIP2":
                Player2.Instance.MuterKiri(new Vector3(float.Parse(aData[1]), float.Parse(aData[2]), float.Parse(aData[3])));
                break;

        }
    }

    private void UserConnected(string name, bool host)
    {
        GameClient c = new GameClient();
        c.name = name;

        players.Add(c);

        if(players.Count == 2)
        {
            GameManager.Instance.StartGame();
        }
    }

    private void OnApplicationQuit()
    {
        CloseSocket();
    }

    private void OnDisable()
    {
        CloseSocket();
    }
    private void CloseSocket()
    {
        if(!socketReady)
        {
            return;
        }

        writer.Close();
        reader.Close();
        socket.Close();
        socketReady = false;
    }
}

public class GameClient
{
    public string name;
    public bool isHost;
}
