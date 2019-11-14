using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2 : MonoBehaviour
{
    public bool player2;
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public static int point;
    public GameObject pointtext;
    [SerializeField] Text pointsCounterText;

    // Start is called before the first frame update
    void Start()
    {
        Client c = FindObjectOfType<Client>();
        player2 = c.isHost;

        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player2 == true)
        {
            pointsCounterText.text = point.ToString();
            transform.Rotate(0, Input.GetAxis("Horizontal2") * Time.deltaTime * rotationSpeed, 0);

            if (Input.GetKey(KeyCode.I))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical2") * Time.deltaTime * movementSpeed);
            }
            if (Input.GetKeyDown(KeyCode.K))
            {
                transform.Rotate(0, transform.rotation.y + 180, 0);
            }
            if (Input.GetKey(KeyCode.K))
            {
                transform.Translate(0, 0, Input.GetAxis("Vertical2") * Time.deltaTime * movementSpeed * -1);
            }
        } else
        {

        }
    }
}
