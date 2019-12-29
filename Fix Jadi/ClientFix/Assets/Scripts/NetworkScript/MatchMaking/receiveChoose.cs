using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine;

using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class receiveChoose : MonoBehaviour
{
    public chooseScript choose;

    public TcpClient client;
    public StreamReader reader;
    public StreamWriter writer;

    void Start()
    {
        client = new TcpClient("127.0.0.1", 8080);
        Debug.Log(" [Berhasil Terhubung...]");

        reader = new StreamReader(client.GetStream());
        writer = new StreamWriter(client.GetStream());

        writer.WriteLine("need character1");
        writer.Flush();
    }

    void Update()
    {
        string recv = reader.ReadLine();
        Debug.Log(recv);
    }
}