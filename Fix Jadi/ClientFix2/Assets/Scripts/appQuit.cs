using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class appQuit : MonoBehaviour
{
    private Button Quit;

    // Start is called before the first frame update
    void Start()
    {
        Quit = GetComponent<Button>();
        Quit.onClick.AddListener(quit);
    }

    public void quit()
    {
        Application.Quit();
    }
}
