using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class turnOn : MonoBehaviour
{
    private Button turn;
    public TextMeshProUGUI wait;
    public Image batas;
    public DownloadScript dwnld;
    
    // Start is called before the first frame update
    void Start()
    {
        batas.enabled = false;
        wait.text = string.Empty;
        turn = GetComponent<Button>();
        turn.onClick.AddListener(turned);
    }

    void Update()
    {
        if (dwnld.downloaded == false)
        {
            Debug.Log("...");
        }
        else if (dwnld.downloaded == true)
        {
            Debug.Log("Downloading...");
        }

        if (dwnld.downloaded == true)
        {
            wait.text = "< The File Downloaded Successfully >";
        }
    }

    void turned()
    {
        wait.text = "< Please Wait, Downloading >";
        batas.enabled = true;
    }

    void moveScene()
    {
        SceneManager.LoadScene(1);
    }
}
