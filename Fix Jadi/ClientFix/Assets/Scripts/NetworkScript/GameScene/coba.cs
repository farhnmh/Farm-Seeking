//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine.UI;
//using UnityEngine;

//using System;
//using System.Net.Sockets;
//using System.IO;
//using System.Threading;

//[Serializable]
//public class dataPlayer1
//{
//    public float positX;
//    public float positY;
//    public float positZ;
//}

//public class coba : MonoBehaviour
//{
//    public float task;
//    public float speed;
//    public bool done = false;

//    public GameObject player1Pos;

//    public TcpClient client;
//    public StreamReader reader;
//    public StreamWriter writer;
//    public dataPlayer1 player1;

//    public float xBefore;
//    public float yBefore;
//    public float zBefore;

//    public float xAfter;
//    public float yAfter;
//    public float zAfter;

//    bool start = false;

//    void Start()
//    {
//        client = new TcpClient("127.0.0.1", 8080);
//        Debug.Log(" [Berhasil Terhubung...]");

//        reader = new StreamReader(client.GetStream());
//        writer = new StreamWriter(client.GetStream());

//        player1 = new dataPlayer1();

//        start = true;
//        writer.WriteLine("player1");
//        writer.Flush();

//        Thread Client = new Thread(joinServer);
//        Client.Start();
//    }

//    void Update()
//    {
//        if (start)
//        {
//            xBefore = player1Pos.transform.position.x;
//            yBefore = player1Pos.transform.position.y;
//            yBefore = player1Pos.transform.position.y;

//            player1.positX = player1Pos.transform.position.x;
//            player1.positY = player1Pos.transform.position.y;
//            player1.positZ = player1Pos.transform.position.z;

//            task += 1 * Time.deltaTime;
//            if (task >= 0.2f && xAfter != xBefore || task >= 0.2f && yAfter != yBefore || task >= 0.2f && zAfter != zBefore)
//            {
//                string player1Data = JsonUtility.ToJson(player1);
//                writer.WriteLine(player1Data);
//                writer.Flush();

//                task = 0;
//            }
//            else if (task >= 0.8f)
//            {
//                task = 0;
//            }

//            xAfter = xBefore;
//            yAfter = yBefore;
//            zAfter = zBefore;
//        }
//    }

//    void joinServer()
//    {
//        StreamWriter w = new StreamWriter(client.GetStream());
//        StreamReader r = new StreamReader(client.GetStream());

//        while (true)
//        {
//            string player1Data = r.ReadLine();
//            player1 = JsonUtility.FromJson<dataPlayer1>(player1Data);
//            Debug.Log(" Player-1 (" + player1.positX + ", " + player1.positY + ", " + player1.positZ + ")");
//        }
//    }
//}