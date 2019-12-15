using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    public static int game;

    void Start()
    {
        game = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(game >= 5)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
