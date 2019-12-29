using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class sendChoose : MonoBehaviour
{
    public chooseScript choose;

    public TcpClient client;
    public StreamReader reader;
    public StreamWriter writer;

    bool start = false;

    void Start()
    {
        client = new TcpClient(PlayerPrefs.GetString("ip address"), 8080);
        Debug.Log(" [Berhasil Terhubung...]");

        reader = new StreamReader(client.GetStream());
        writer = new StreamWriter(client.GetStream());

        writer.WriteLine(PlayerPrefs.GetString("username"));
        writer.Flush();
        start = true;
    }

    void Update()
    {
        if (start)
        {
            writer.WriteLine(Convert.ToString(choose.choosePlayer));
            writer.Flush();
        }
    }
}