using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGather : MonoBehaviour
{
    public Player p;
    public SpawnFruitCards c;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        switch (other.gameObject.name)
        {
            case "Fruits1(Clone)":
                if (c.cardNum == 1)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Apple(Clone)":
                if (c.cardNum == 1)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Fruits2(Clone)":
                if (c.cardNum == 2)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Beet(Clone)":
                if (c.cardNum == 2)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Fruits3(Clone)":
                if (c.cardNum == 3)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Fruits4(Clone)":
                if (c.cardNum == 4)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;

            case "Banana(Clone)":
                if (c.cardNum == 4)
                {
                    Player.point += 1;
                }
                Destroy(other.gameObject);
                break;
        }
      
    }
}
