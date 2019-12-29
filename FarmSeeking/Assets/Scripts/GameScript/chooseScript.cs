
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class chooseScript : MonoBehaviour
{
    public Image redLeft;
    public Image greenLeft;
    public Image blueLeft;

    public Image redRight;
    public Image greenRight;
    public Image blueRight;

    public int player = 1;
    public string colour = string.Empty;
    public Text texting;

    // Start is called before the first frame update
    void Start()
    {
        redLeft.enabled = false;
        greenLeft.enabled = false;
        blueLeft.enabled = false;

        redRight.enabled = false;
        greenRight.enabled = false;
        blueRight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (colour == "red")
        {
            if (player == 1)
            {
                redLeft.enabled = true;
                greenLeft.enabled = false;
                blueLeft.enabled = false;
            }
            if (player == 2)
            {
                redRight.enabled = true;
                greenRight.enabled = false;
                blueRight.enabled = false;
            }
        }
        if (colour == "green")
        {
            if (player == 1)
            {
                redLeft.enabled = false;
                greenLeft.enabled = true;
                blueLeft.enabled = false;
            }
            if (player == 2)
            {
                redRight.enabled = false;
                greenRight.enabled = true;
                blueRight.enabled = false;
            }
        }
        if (colour == "blue")
        {
            if (player == 1)
            {
                redLeft.enabled = false;
                greenLeft.enabled = false;
                blueLeft.enabled = true;
            }
            if (player == 2)
            {
                redRight.enabled = false;
                greenRight.enabled = false;
                blueRight.enabled = true;
            }
        }
    }
}