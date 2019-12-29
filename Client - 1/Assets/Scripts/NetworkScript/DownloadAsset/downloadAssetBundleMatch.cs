using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downloadAssetBundleMatch : MonoBehaviour
{
    public bool done = false;
    public string url;

    public List<string> gameObjectString;
    private GameObject choose;

    void Start()
    {
        choose = GameObject.FindGameObjectWithTag("choose");
        choose.SetActive(false);

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
            Instantiate(background);

            GameObject blue = (GameObject)bundle.LoadAsset(gameObjectString[1]);
            Instantiate(blue);
            GameObject blueLeft = (GameObject)bundle.LoadAsset(gameObjectString[2]);
            Instantiate(blueLeft);

            GameObject green = (GameObject)bundle.LoadAsset(gameObjectString[3]);
            Instantiate(green);
            GameObject greenLeft = (GameObject)bundle.LoadAsset(gameObjectString[4]);
            Instantiate(greenLeft);

            GameObject red = (GameObject)bundle.LoadAsset(gameObjectString[5]);
            Instantiate(red);
            GameObject redLeft = (GameObject)bundle.LoadAsset(gameObjectString[6]);
            Instantiate(redLeft);

            GameObject subTitle = (GameObject)bundle.LoadAsset(gameObjectString[7]);
            Instantiate(subTitle);
            GameObject subTitle1 = (GameObject)bundle.LoadAsset(gameObjectString[8]);
            Instantiate(subTitle1);
            GameObject title = (GameObject)bundle.LoadAsset(gameObjectString[9]);
            Instantiate(title);
        }
        else
            Debug.Log(www.error);

        done = true;
        Debug.Log("finished");
        choose.SetActive(true);
    }
}