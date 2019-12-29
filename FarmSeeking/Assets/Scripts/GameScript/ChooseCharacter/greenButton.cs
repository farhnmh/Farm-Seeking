
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class greenButton : MonoBehaviour
{
    private Button choose;
    public chooseScript chosen;

    // Start is called before the first frame update
    void Start()
    {
        choose = GetComponent<Button>();
        choose.onClick.AddListener(choice);
    }

    void choice()
    {
        chosen.colour = "green";
    }
}