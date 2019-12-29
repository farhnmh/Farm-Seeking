using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class chooseScript : MonoBehaviour
{
    public int choosePlayer;
    public int sceneID;

    public PassingData pass;

    SpriteRenderer colorBlueLeft;
    SpriteRenderer colorGreenLeft;
    SpriteRenderer colorRedLeft;

    GameObject blueLeft;
    GameObject greenLeft;
    GameObject redLeft;

    public Button blue;
    public Button green;
    public Button red;

    void Start()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();

        red.onClick.AddListener(chooseRed);
        green.onClick.AddListener(chooseGreen);
        blue.onClick.AddListener(chooseBlue);    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetKeyDown(KeyCode.Return) && choosePlayer != 0)
        {
            SceneManager.LoadScene(sceneID);
        }

        blueLeft = GameObject.Find("blueLeft(Clone)");
        greenLeft = GameObject.Find("greenLeft(Clone)");
        redLeft = GameObject.Find("redLeft(Clone)");

        colorBlueLeft = blueLeft.GetComponent<SpriteRenderer>();
        colorGreenLeft = greenLeft.GetComponent<SpriteRenderer>();
        colorRedLeft = redLeft.GetComponent<SpriteRenderer>();

        if (choosePlayer == 0)
        {
            colorRedLeft.color = new Color(1, 1, 1, 0.0f);
            colorGreenLeft.color = new Color(1, 1, 1, 0.0f);
            colorBlueLeft.color = new Color(1, 1, 1, 0.0f);
        }

        pass.character = choosePlayer;
    }

    void chooseRed()
    {
        Debug.Log("red");
        colorRedLeft.color = new Color(1, 1, 1, 1.0f);
        colorGreenLeft.color = new Color(1, 1, 1, 0.0f);
        colorBlueLeft.color = new Color(1, 1, 1, 0.0f);

        choosePlayer = 1;
    }

    void chooseGreen()
    {
        Debug.Log("green");
        colorRedLeft.color = new Color(1, 1, 1, 0.0f);
        colorGreenLeft.color = new Color(1, 1, 1, 1.0f);
        colorBlueLeft.color = new Color(1, 1, 1, 0.0f);

        choosePlayer = 2;
    }

    void chooseBlue()
    {
        Debug.Log("blue");
        colorRedLeft.color = new Color(1, 1, 1, 0.0f);
        colorGreenLeft.color = new Color(1, 1, 1, 0.0f);
        colorBlueLeft.color = new Color(1, 1, 1, 1.0f);

        choosePlayer = 3;
    }
}
