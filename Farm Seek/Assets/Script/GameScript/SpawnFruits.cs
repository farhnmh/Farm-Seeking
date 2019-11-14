using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    //Prefab yang akan di-instantiate.
    public GameObject prefab1, prefab2, prefab3, prefab4, prefab5, prefab6, prefab7;

    //Waktu spawn.
    public float spawnRate = 2f;

    //Variabel untuk mengatur spawn time berikutnya.
    float nextSpawn = 0f;

    //Variabel yang memiliki nilai random.
    int whatToSpawn;

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            whatToSpawn = Random.Range(1, 8);
            Debug.Log(whatToSpawn);

            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(prefab1, transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(prefab2, transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(prefab3, transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(prefab4, transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(prefab5, transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(prefab6, transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(prefab7, transform.position, Quaternion.identity);
                    break;
            }

            //set next spawn time
            nextSpawn = Time.time + spawnRate;
        }
    }
}
