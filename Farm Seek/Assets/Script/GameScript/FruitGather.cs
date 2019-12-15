using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitGather : MonoBehaviour
{
    public static FruitGather Instance { set; get; }
    public Player p;
    public Player2 p2;
    public int point;
    public SpawnFruitCards c;

    private Client client;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        client = FindObjectOfType<Client>();
        point = 1;
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
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                Destroy(other.gameObject);
                GameOver.game += 1;
                break;

            case "Apple(Clone)":
                if (c.cardNum == 1)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;

            case "Fruits2(Clone)":
                if (c.cardNum == 2)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;

            case "Beet(Clone)":
                if (c.cardNum == 2)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;

            case "Fruits3(Clone)":
                if (c.cardNum == 3)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;

            case "Fruits4(Clone)":
                if (c.cardNum == 4)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;

            case "Banana(Clone)":
                if (c.cardNum == 4)
                {
                    if (Object.Instance.melempar == true)
                    {
                        client.Send("POINT|" + point);
                        Object.Instance.melempar = false;
                    }
                    else
                    {
                        client.Send("POINT2|" + point);
                    }
                }
                GameOver.game += 1;
                Destroy(other.gameObject);
                break;
        }
      
    }
}
