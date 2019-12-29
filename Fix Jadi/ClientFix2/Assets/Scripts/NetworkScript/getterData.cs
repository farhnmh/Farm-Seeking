using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getterData : MonoBehaviour
{
    public int urutan;
    public int urutanOther;
    public string username;
    public string ipAddress;
    public int character;
    public int characterOther;
    public int totalClient;
    public int score;
    public bool temp = false;

    public PassingData pass;
    public downloadBundleGame bundle;
    public sendData data;

    public GameObject connectButton;

    void Start()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();
        bundle = GameObject.Find("DownloadBundle").GetComponent<downloadBundleGame>();
        data = GameObject.Find("SendingScript").GetComponent<sendData>();

        connectButton.SetActive(false);    
    }

    // Update is called once per frame
    void Update()
    {
        urutan = pass.urutan;
        urutanOther = pass.urutanOther;
        username = pass.username;
        ipAddress = pass.ipAddress;
        character = pass.character;
        characterOther = pass.characterOther;
        totalClient = data.totalClient;
        pass.score = score;

        if (totalClient == 2)
        {
            connectButton.SetActive(true);
        }
    }
}
