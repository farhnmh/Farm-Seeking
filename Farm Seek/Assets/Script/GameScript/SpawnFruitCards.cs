using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruitCards : MonoBehaviour
{
    public static SpawnFruitCards Instance { set; get; }

    //Client
    private Client client;
    public bool server;
    public int serverSpawn;

    //Prefab yang akan di-instantiate.
    public GameObject prefab1, prefab2, prefab3, prefab4;
    public float cardNum;


    //Waktu spawn.
    public float spawnRate = 1.5f;

    //Variabel untuk mengatur spawn time berikutnya.
    float nextSpawn = 0f;

    //Variabel yang memiliki nilai random.
    //int whatToSpawn;

    //Start
    void Start()
    {
        Instance = this;
        client = FindObjectOfType<Client>();
        server = client.isHost;
        serverSpawn = 1;

        if (server == false)
        {
            switch (serverSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    cardNum = 1;
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    cardNum = 2;
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    cardNum = 3;
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    cardNum = 4;
                    break;
            }
        }
            

        Debug.Log("Card :" + cardNum);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextSpawn)
        {

            if (server == true)
            {
                int whatToSpawn;
                whatToSpawn = Random.Range(1, 5);
                client.Send("SPAWN|" + whatToSpawn);
            }

            Debug.Log("NumSp :" + serverSpawn);

            switch (serverSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    cardNum = 1;
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    cardNum = 2;
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    cardNum = 3;
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    cardNum = 4;
                    break;
            }

            Debug.Log("Card :" + cardNum);
             nextSpawn = Time.time + spawnRate;
        }
    }
}
