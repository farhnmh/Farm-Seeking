using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoring : MonoBehaviour
{
    public getterData get;
    public int score;

    void Update()
    {
        get = GameObject.Find("BackgroundScript").GetComponent<getterData>();    
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "apel")
        {
            score = get.score += 2;
        }
        if (collision.gameObject.tag == "belimbing")
        {
            score = get.score += 3;
        }
        if (collision.gameObject.tag == "jeruk")
        {
            score = get.score += 1;
        }
        if (collision.gameObject.tag == "lemon")
        {
            score = get.score += 1;
        }
        if (collision.gameObject.tag == "manggis")
        {
            score = get.score += 1;
        }
        if (collision.gameObject.tag == "pisang")
        {
            score = get.score += 3;
        }
    }
}
