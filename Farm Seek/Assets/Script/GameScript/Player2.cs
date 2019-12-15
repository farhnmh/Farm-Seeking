using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public static Player2 Instance { set; get; }
    public bool player2;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public static int point;
    public GameObject pointtext;
    [SerializeField] Text pointsCounterText;
    private Client c;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        c = FindObjectOfType<Client>();
        player2 = c.isHost;

        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player2 == true)
        {
            //pointsCounterText.text = point.ToString();
            //transform.Rotate(0, Input.GetAxis("Horizontal2") * Time.deltaTime * rotationSpeed, 0);

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
                float x = 0;
                float y = 0;
                float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed;
                c.Send("MAJUP2|" + x + "|" + y + "|" + z);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.Rotate(0, transform.rotation.y + 180, 0);
                float x = 0;
                float y = transform.rotation.y + 180;
                float z = 0;
                c.Send("BALIKP2|" + x + "|" + y + "|" + z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1);
                float x = 0;
                float y = 0;
                float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1;
                c.Send("MUNDURP2|" + x + "|" + y + "|" + z);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
                float x = 0;
                float y = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
                float z = 0;
                c.Send("MUTERKANANP2|" + x + "|" + y + "|" + z);
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
                float x = 0;
                float y = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
                float z = 0;
                c.Send("MUTERKIRIP2|" + x + "|" + y + "|" + z);
            }
        }
    }

    public void addPoint(int p)
    {
        if (player2 == true)
        {
            point += p;
            p = 0;
            pointsCounterText.text = point.ToString();
        }
        else if (player2 == false)
        {
            point += p;
            p = 0;
            pointsCounterText.text = point.ToString();
        }

    }

    public void Maju(Vector3 pos)
    {
        transform.Translate(pos);
    }

    public void Balik(Vector3 pos)
    {
        if (player2 == false)
        {
           transform.Rotate(pos);
        }
           
    }
    public void Mundur(Vector3 pos)
    {
        transform.Translate(pos);
    }

    public void MuterKanan(Vector3 pos)
    {
        if (player2 == false)
        {
            transform.Rotate(pos);
        }
    }

    public void MuterKiri(Vector3 pos)
    {
        if (player2 == false)
        {
            transform.Rotate(pos);
        }
    }
}
