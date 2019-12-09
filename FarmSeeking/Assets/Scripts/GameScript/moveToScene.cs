<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class moveToScene : MonoBehaviour
{
    private Button thisButton;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(move);
    }

    void move()
    {
        SceneManager.LoadScene(sceneName);
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class moveToScene : MonoBehaviour
{
    private Button thisButton;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.onClick.AddListener(move);
    }

    void move()
    {
        SceneManager.LoadScene(sceneName);
    }
}
>>>>>>> d7c7e4a905e041ffe305001e573a433cc87eb6b7
