using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class backgroundScript : MonoBehaviour
{
    public bool done = false;
    public int sceneID;

    public TextMeshProUGUI hello;
    public TextMeshProUGUI warning;
    public TextMeshProUGUI instruct;
    public TextMeshProUGUI click;

    public Text from;
    public Text ip;
    public Button submit;
    public GameObject PanelSubmit;
    public PassingData pass;

    // Start is called before the first frame update
    void Start()
    {
        submit.onClick.AddListener(submitClicked);
        PanelSubmit.SetActive(true);

        instruct.text = "Please Input Your Name\nand Every Scene Will Download Asset";
        warning.text = "";
        hello.text = "";
        click.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();

        pass.username = from.text;
        pass.ipAddress = ip.text;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (from.text == "" || ip.text == "")
            {
                PanelSubmit.SetActive(true);
                warning.text = "<- don't let it empty";
            }
            else
            {
                PanelSubmit.SetActive(false);
                instruct.text = "";
                warning.text = "";
                hello.text = "Hello " + from.text;
                click.text = "click everywhere to continue";
                done = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && done == true)
        {
            SceneManager.LoadScene(sceneID);
        }
    }

    void submitClicked()
    {
        if (from.text == "" || ip.text == "")
        {
            PanelSubmit.SetActive(true);
            warning.text = "don't let it empty";
        }
        else
        {
            PanelSubmit.SetActive(false);
            instruct.text = "";
            warning.text = "";
            hello.text = "Hello " + from.text;
            click.text = "click here to continue";
            done = true;
        }
    }
}
