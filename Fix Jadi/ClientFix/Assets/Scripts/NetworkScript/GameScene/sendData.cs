using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class sendData : MonoBehaviour
{
    [Serializable]
    public class dataPlayer
    {
        public float positX;
        public float positY;
        public float positZ;
        public int score;
    }

    public float task;
    public float speed;
    public int characterEnemy;
    public int totalClient;
    public bool done = false;

    public PassingData pass;
    public GameObject playerPos;

    public TcpClient client;
    public StreamReader reader;
    public StreamWriter writer;

    public dataPlayer player;

    float xBefore;
    float yBefore;
    float zBefore;

    float xAfter;
    float yAfter;
    float zAfter;

    public bool start = false;

    void Start()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();

        client = new TcpClient(pass.ipAddress, 8080);
        Debug.Log(" [Berhasil Terhubung...]");

        reader = new StreamReader(client.GetStream());
        writer = new StreamWriter(client.GetStream());

        player = new dataPlayer();

        start = true;
        writer.WriteLine(pass.usernameEncrypt);
        writer.Flush();

        writer.WriteLine(pass.password);
        writer.Flush();

        writer.WriteLine(Convert.ToString(pass.character));
        writer.Flush();

        string urut = reader.ReadLine();
        pass.urutan = Int32.Parse(urut);

        Thread Client = new Thread(joinServer);
        Client.Start();
    }

    void Update()
    {
        if (pass.urutan == 1)
        {
            pass.urutanOther = 2;
            if (pass.character == 1)
            {
                playerPos = GameObject.Find("red_1(Clone)");
            }
            else if (pass.character == 2)
            {
                playerPos = GameObject.Find("green_1(Clone)");
            }
            else if (pass.character == 3)
            {
                playerPos = GameObject.Find("blue_1(Clone)");
            }
        }
        else if (pass.urutan == 2)
        {
            pass.urutanOther = 1;
            if (pass.character == 1)
            {
                playerPos = GameObject.Find("red_2(Clone)");
            }
            else if (pass.character == 2)
            {
                playerPos = GameObject.Find("green_2(Clone)");
            }
            else if (pass.character == 3)
            {
                playerPos = GameObject.Find("blue_2(Clone)");
            }
        }

        if (start)
        {
            xBefore = playerPos.transform.position.x;
            yBefore = playerPos.transform.position.y;
            zBefore = playerPos.transform.position.z;

            player.positX = playerPos.transform.position.x;
            player.positY = playerPos.transform.position.y;
            player.positZ = playerPos.transform.position.z;

            player.score = pass.score;

            task += 1 * Time.deltaTime;
            if (xAfter != xBefore || yAfter != yBefore || zAfter != zBefore)
            {
                string player1Data = JsonUtility.ToJson(player);
                writer.WriteLine(player1Data);
                writer.Flush();

                task = 0;
            }
            else if (task >= 0.8f)
            {
                task = 0;
            }

            xAfter = xBefore;
            yAfter = yBefore;
            zAfter = zBefore;
        }
    }

    void joinServer()
    {
        StreamWriter w = new StreamWriter(client.GetStream());
        StreamReader r = new StreamReader(client.GetStream());

        while (totalClient != 2)
        {
            string ready = r.ReadLine();
            totalClient = Int32.Parse(ready);
            pass.totalClient = totalClient;
        }
    }
}