using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class receiveData : MonoBehaviour
{
    [Serializable]
    public class dataPlayer
    {
        public float positX;
        public float positY;
        public float positZ;
        public int score;
    }

    public int sceneID;
    public int timer = 25;
    public int charEnemy;
    public int match = 3;
    public bool spawn = false;
    public bool start = false;
    public bool firstMatch = false;

    public downloadBundleGame bundle;
    public getterData get;
    public PassingData pass;

    public TextMeshProUGUI time;
    public TextMeshProUGUI instruct;

    public GameObject playerOtherPos;
    public GameObject connectButton;

    public GameObject red;
    public GameObject green;
    public GameObject blue;

    public GameObject player_1;
    public GameObject player_2;

    public TcpClient client;
    public StreamReader reader;
    public StreamWriter writer;

    public dataPlayer playerOther;

    void Start()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();
        get = GameObject.Find("BackgroundScript").GetComponent<getterData>();
        bundle = GameObject.Find("DownloadBundle").GetComponent<downloadBundleGame>();

        client = new TcpClient("127.0.0.1", 8080);
        Debug.Log(" [Berhasil Terhubung...]");

        reader = new StreamReader(client.GetStream());
        writer = new StreamWriter(client.GetStream());

        playerOther = new dataPlayer();

        start = true;
        get.temp = true;

        writer.WriteLine(pass.usernameEncrypt);
        writer.Flush();

        writer.WriteLine(pass.password);
        writer.Flush();

        Thread Client = new Thread(joinServer);
        Client.Start();
    }

    void Update()
    {
        if (start)
        {
            if (pass.totalClient == 2 && bundle.done == true)
            {
                if (pass.characterOther == 1 && pass.urutanOther == 1)
                {
                    Instantiate(red, player_1.transform.position, Quaternion.identity);
                    connectButton.SetActive(false);
                }
                else if (pass.characterOther == 2 && pass.urutanOther == 1)
                {
                    Instantiate(green, player_1.transform.position, Quaternion.identity);
                }
                else if (pass.characterOther == 3 && pass.urutanOther == 1)
                {
                    Instantiate(blue, player_1.transform.position, Quaternion.identity);
                }
                else if (pass.characterOther == 1 && pass.urutanOther == 2)
                {
                    Instantiate(red, player_2.transform.position, Quaternion.identity);
                }
                else if (pass.characterOther == 2 && pass.urutanOther == 2)
                {
                    Instantiate(green, player_2.transform.position, Quaternion.identity);
                }
                else if (pass.characterOther == 3 && pass.urutanOther == 2)
                {
                    Instantiate(blue, player_2.transform.position, Quaternion.identity);
                }

                bundle.done = false;
            }

            connectButton.SetActive(false);

            if (!firstMatch)
            {
                instruct.text = "GET READY!!!";
                firstMatch = true;
                match++;
            }

            time.text = "time left " + timer + "s";
            if (timer == 0 && firstMatch)
            {
                instruct.text = "GET READY!!!";
                match++;
                Thread.Sleep(1500);
            }
            else if (timer != 0 && firstMatch)
                instruct.text = "GO FASTER!!!";

            pass.characterOther = charEnemy;
            pass.scoreOther = playerOther.score;

            playerOtherPos = GameObject.FindGameObjectWithTag("playerOther");
            playerOtherPos.transform.position = new Vector3(playerOther.positX, playerOther.positY, playerOther.positZ);

            if (timer == -1)
            {
                SceneManager.LoadScene(sceneID);
            }
        }
    }

    void joinServer()
    {
        StreamWriter w = new StreamWriter(client.GetStream());
        StreamReader r = new StreamReader(client.GetStream());

        while (true)
        {
            string Char = r.ReadLine();
            pass.characterOther = Int32.Parse(Char);

            string playerOtherData = r.ReadLine();
            playerOther = JsonUtility.FromJson<dataPlayer>(playerOtherData);

            string time = r.ReadLine();
            timer = Int32.Parse(time);
        }
    }
}