using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class toScene : MonoBehaviour
{
    private Button This;
    public int SceneID;

    // Start is called before the first frame update
    void Start()
    {
        This = GetComponent<Button>();
        This.onClick.AddListener(clicked);
    }

    void clicked()
    {
        SceneManager.LoadScene(SceneID);
    }
}
