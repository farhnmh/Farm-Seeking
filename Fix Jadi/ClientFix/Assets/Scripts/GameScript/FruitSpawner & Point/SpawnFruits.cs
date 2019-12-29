using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFruits : MonoBehaviour
{
    //Prefab yang akan di-instantiate.
    public GameObject fruits;

    //Waktu spawn.
    public float spawnRate = 2f;

    //Variabel untuk mengatur spawn time berikutnya.
    float nextSpawn = 0f;


    private void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            Instantiate(fruits, transform.position, Quaternion.identity);
            //set next spawn time
            nextSpawn = Time.time + spawnRate;
        }
    }
}
