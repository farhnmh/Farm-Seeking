using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPlayer : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float rotationSpeed = 200.0f;
    public sendData send;

    // Update is called once per frame
    void Update()
    {
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

        //if (Input.GetKey(KeyCode.D))
        //{
        //    send.player1.rotate = 1;
        //    transform.Rotate(0, send.player1.rotate * Time.deltaTime * rotationSpeed, 0);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    send.player1.rotate = -1;
        //    transform.Rotate(0, send.player1.rotate * Time.deltaTime * rotationSpeed, 0);
        //}
    }
}
