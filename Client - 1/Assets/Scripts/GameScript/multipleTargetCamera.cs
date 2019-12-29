using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multipleTargetCamera : MonoBehaviour
{
    public PassingData pass;
    public GameObject player;

    void Update()
    {
        pass = GameObject.Find("PassingData").GetComponent<PassingData>();

        if (pass.urutan == 1)
        {
            if (pass.character == 1)
            {
                player = GameObject.Find("red_1(Clone)");
            }
            else if (pass.character == 2)
            {
                player = GameObject.Find("green_1(Clone)");
            }
            else if (pass.character == 3)
            {
                player = GameObject.Find("blue_1(Clone)");
            }
        }
        else if (pass.urutan == 2)
        {
            if (pass.character == 1)
            {
                player = GameObject.Find("red_2(Clone)");
            }
            else if (pass.character == 2)
            {
                player = GameObject.Find("green_2(Clone)");
            }
            else if (pass.character == 3)
            {
                player = GameObject.Find("blue_2(Clone)");
            }
        }

        gameObject.transform.position = new Vector3(gameObject.transform.position.x, 
                                                    gameObject.transform.position.y, 
                                                    player.transform.position.z - 8.68f);    
    }
}