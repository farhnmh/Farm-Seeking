<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class redButton : MonoBehaviour
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
        chosen.colour = "red";
    }
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class redButton : MonoBehaviour
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
        chosen.colour = "red";
    }
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
}