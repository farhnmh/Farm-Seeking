using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerPlayer : MonoBehaviour
{
    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    public float movementSpeed;
    public float rotationSpeed;
    public sendData send;

    // Update is called once per frame
    void Update()
    {
        send = GameObject.Find("SendingScript").GetComponent<sendData>();

        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);

        ApplyInput(moveAxis, turnAxis);
    }

    private void ApplyInput(float moveInput, float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }

    private void Move(float input)
    {
        transform.Translate(Vector3.forward * input * movementSpeed);
    }

    private void Turn(float input)
    {
        transform.Rotate(0, input * rotationSpeed * Time.deltaTime, 0);
    }
}
