using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public static int game;

    void Start()
    {
        game = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //Kondisi menang kalah
        //Jadi setelah lima kali main permainan selesai
        //Di-check siapa yang punya poin terbanyak
        //Lalu pindah ke scene game over???
        
        if (game >= 5 && PlayerPoint.point > PlayerPoint2.point)
        {
            SceneManager.LoadScene("GameOverP1Win");
        }

        if (game >= 5 && PlayerPoint.point < PlayerPoint2.point)
        {
            SceneManager.LoadScene("GameOverP2Win");
        }

        if (game >= 5 && PlayerPoint.point == PlayerPoint2.point)
        {
            SceneManager.LoadScene("GameOverDraw");
        }
        

    }
}
