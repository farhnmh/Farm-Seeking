using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class setActive : MonoBehaviour
{
    private Button This;
    public GameObject connection;

    // Start is called before the first frame update
    void Start()
    {
        connection.SetActive(false);

        This = GetComponent<Button>();
        This.onClick.AddListener(join);
    }

    void join()
    {
        connection.SetActive(true);
    }
}
