using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class downloadBundleGame : MonoBehaviour
{
    public bool done = false;
    public string url;
    
    public int character;
    public int urutan;

    public PassingData pass;
    public GameObject player_1;
    public GameObject player_2;

    public List<string> gameObjectString;

    void Start()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();
        StartCoroutine(GetAssetBundle());
        Debug.Log("pushed");
    }

    void Update()
    {
        character = pass.character;
        urutan = pass.urutan;
    }

    IEnumerator GetAssetBundle()
    {
        WWW www = new WWW(url);
        yield return www;

        Debug.Log("entered");

        AssetBundle bundle = www.assetBundle;
        if (www.error == null)
        {
            if (character == 1 && urutan == 1) {
                GameObject red_1 = (GameObject)bundle.LoadAsset(gameObjectString[0]);
                Instantiate(red_1, player_1.transform.position, Quaternion.identity);
            }
            else if (character == 2 && urutan == 1)
            {
                GameObject green_1 = (GameObject)bundle.LoadAsset(gameObjectString[1]);
                Instantiate(green_1, player_1.transform.position, Quaternion.identity);
            }
            else if (character == 3 && urutan == 1)
            {
                GameObject blue_1 = (GameObject)bundle.LoadAsset(gameObjectString[2]);
                Instantiate(blue_1, player_1.transform.position, Quaternion.identity);
            }
            else if (character == 1 && urutan == 2)
            {
                GameObject red_2 = (GameObject)bundle.LoadAsset(gameObjectString[3]);
                Instantiate(red_2, player_2.transform.position, Quaternion.identity);
            }
            else if (character == 2 && urutan == 2)
            {
                GameObject green_2 = (GameObject)bundle.LoadAsset(gameObjectString[4]);
                Instantiate(green_2, player_2.transform.position, Quaternion.identity);
            }
            else if (character == 3 && urutan == 2)
            {
                GameObject blue_2 = (GameObject)bundle.LoadAsset(gameObjectString[5]);
                Instantiate(blue_2, player_2.transform.position, Quaternion.identity);
            }

            GameObject map_1 = (GameObject)bundle.LoadAsset(gameObjectString[6]);
            Instantiate(map_1);

            GameObject map_2 = (GameObject)bundle.LoadAsset(gameObjectString[7]);
            Instantiate(map_2);

            GameObject fruit_1 = (GameObject)bundle.LoadAsset(gameObjectString[8]);
            Instantiate(fruit_1);

            GameObject fruit_2 = (GameObject)bundle.LoadAsset(gameObjectString[9]);
            Instantiate(fruit_2);
        }
        else
            Debug.Log(www.error);

        done = true;
        Debug.Log("finished");
    }
}