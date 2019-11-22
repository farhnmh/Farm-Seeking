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
            pointsCounterText.text = point.ToString();
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
            float x1 = 0;
            float y1 = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
            float z1 = 0;

            client.Send("MUTERP1|" + x1 + "|" + y1 + "|" + z1);
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
                float y = transform.rotation.y;
                float z = 0;
                client.Send("BELAKANGP1|" + x + "|" + y + "|" + z);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1);
                float x = 0;
                float y = 0;
                float z = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1;
                client.Send("MUNDURP1|" + x + "|" + y + "|" + z);
            }
        }
    }
    public void Maju(Vector3 pos)
    {
        transform.Translate(pos);
    }

    public void Muter(Vector3 ros)
    {
        transform.Rotate(ros);
    }
    public void Belakang(Vector3 cos)
    {
        transform.Rotate(cos);
    }
}
