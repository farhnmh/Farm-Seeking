<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class turnOn : MonoBehaviour
{
    private Button turn;
    public TextMeshProUGUI wait;
    public Image batas;
    public GameObject dwnld;
    
    // Start is called before the first frame update
    void Start()
    {
        dwnld.SetActive(false);
        batas.enabled = false;
        wait.text = string.Empty;
        turn = GetComponent<Button>();
        turn.onClick.AddListener(turned);
    }

    void turned()
    {
        wait.text = "< Please Wait, Downloading >";
        dwnld.SetActive(true);
        batas.enabled = true;
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class turnOn : MonoBehaviour
{
    private Button turn;
    public TextMeshProUGUI wait;
    public Image batas;
    public GameObject dwnld;
    
    // Start is called before the first frame update
    void Start()
    {
        dwnld.SetActive(false);
        batas.enabled = false;
        wait.text = string.Empty;
        turn = GetComponent<Button>();
        turn.onClick.AddListener(turned);
    }

    void turned()
    {
        wait.text = "< Please Wait, Downloading >";
        dwnld.SetActive(true);
        batas.enabled = true;
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
