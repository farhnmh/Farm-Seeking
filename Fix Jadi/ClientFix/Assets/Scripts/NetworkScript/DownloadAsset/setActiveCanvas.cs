using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveCanvas : MonoBehaviour
{
    private downloadAssetBundleMenu bundle;
    public GameObject This;

    // Start is called before the first frame update
    void Start()
    {
        bundle = GameObject.FindGameObjectWithTag("download").GetComponent<downloadAssetBundleMenu>();

        //This = GetComponent<GameObject>();
        This.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (bundle.done == true)
        {
            This.SetActive(true);
        }
    }
}
