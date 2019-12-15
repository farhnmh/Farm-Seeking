using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public static Player Instance { set; get; }
    public bool player;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public static int point;
    public GameObject pointtext;

    [SerializeField] Text pointsCounterText;
    private Client client;

    private void Start()
    {
        Instance = this;
        client = FindObjectOfType<Client>();
        player = client.isHost;
        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }


    // Update is called once per frame
    void Update()
    {
        if (player == false)
        {
            //transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
                float x = 0;
                float y = 0;
                float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
                client.Send("MAJUP1|" + x + "|" + y + "|" + z);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Rotate(0, transform.rotation.y + 180, 0);
                float x = 0;
                float y = transform.rotation.y + 180;
                float z = 0;
                client.Send("BALIKP1|" + x + "|" + y + "|" + z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1);
                float x = 0;
                float y = 0;
                float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1;
                client.Send("MUNDURP1|" + x + "|" + y + "|" + z);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
                float x = 0;
                float y = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
                float z = 0;
                client.Send("MUTERKANANP1|" + x + "|" + y + "|" + z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
                float x = 0;
                float y = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
                float z = 0;
                client.Send("MUTERKIRIP1|" + x + "|" + y + "|" + z);
            }
        }
    }

    public void addPoint(int p)
    {
        if (player == true)
        {
            point += p;
            p = 0;
            pointsCounterText.text = point.ToString();
        }
        else if(player == false)
        {
            point += p;
            p = 0;
            pointsCounterText.text = point.ToString();
        }

    }

    public void Maju(Vector3 pos)
    {
        if (player == true)
        {
            transform.Translate(pos);
        }
    }

    public void Balik(Vector3 pos)
    {
        if (player == true)
        {
            transform.Rotate(pos);
        }
    }

    public void Mundur(Vector3 pos)
    {
        if (player == true)
        {
            transform.Translate(pos);
        }
    }

    public void MuterKanan(Vector3 pos)
    {
        if (player == true)
        {
            transform.Rotate(pos);
        }
    }

    public void MuterKiri(Vector3 pos)
    {
        if (player == true)
        {
            transform.Rotate(pos);
        }
    }

}
