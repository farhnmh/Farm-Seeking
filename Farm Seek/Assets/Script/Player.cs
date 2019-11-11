using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public static int point;
    public GameObject pointtext;
    [SerializeField] Text pointsCounterText;

    private void Start()
    {
        point = 0;
        pointsCounterText = pointtext.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsCounterText.text = point.ToString();
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        //transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(0, transform.rotation.y + 180, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * -1);
        } 
    }
}
