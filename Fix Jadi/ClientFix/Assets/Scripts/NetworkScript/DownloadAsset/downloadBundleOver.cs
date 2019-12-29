using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downloadBundleOver : MonoBehaviour
{
    public bool done = false;
    public string url;

    public List<string> gameObjectString;
    public List<GameObject> gameObjectPosition;

    void Start()
    {
        StartCoroutine(GetAssetBundle());
        Debug.Log("pushed");
    }

    IEnumerator GetAssetBundle()
    {
        WWW www = new WWW(url);
        yield return www;

        Debug.Log("entered");

        AssetBundle bundle = www.assetBundle;
        if (www.error == null)
        {
            GameObject background = (GameObject)bundle.LoadAsset(gameObjectString[0]);
            Instantiate(background, gameObjectPosition[0].transform.position, Quaternion.identity);

            GameObject title = (GameObject)bundle.LoadAsset(gameObjectString[1]);
            Instantiate(title, gameObjectPosition[1].transform.position, Quaternion.identity);

            GameObject subTitle = (GameObject)bundle.LoadAsset(gameObjectString[2]);
            Instantiate(subTitle, gameObjectPosition[2].transform.position, Quaternion.identity);

            GameObject exit = (GameObject)bundle.LoadAsset(gameObjectString[3]);
            Instantiate(exit, gameObjectPosition[3].transform.position, Quaternion.identity);
        }
        else
            Debug.Log(www.error);

        done = true;
        Debug.Log("finished");
    }
}