﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    //Jaringan
    private Client client;
    public bool server;
    public static Object Instance { set; get; }

    private GameObject postHold;
    private Transform holdpoint;
    private GameObject postHold2;
    private Transform holdpoint2;
    public float range = 0.1f;
    public float range2 = 0.1f;
    public float throwForce = 800;
    public float upperForce;
    public float throwForce2 = 800;
    public float upperForce2;
    bool carrying;
    bool carrying2;
    public float fruitNum;

    //Kondisi melempar
    public bool melempar;

    // Start is called before the first frame update
    void Start()
    {
        //Jaringan
        Instance = this;
        client = FindObjectOfType<Client>();
        server = client.isHost;
        
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        postHold = GameObject.FindGameObjectWithTag("hold");
        holdpoint = postHold.GetComponent<Transform>();
        postHold2 = GameObject.FindGameObjectWithTag("hold2");
        holdpoint2 = postHold2.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (this.gameObject.name)
        {
            case "Fruits1(Clone)":
                fruitNum = 1;
                break;

            case "Apple(Clone)":
                fruitNum = 1;
                break;

            case "Fruits2(Clone)":
                fruitNum = 2;
                break;

            case "Beet(Clone)":
                fruitNum = 2;
                break;

            case "Fruits3(Clone)":
                fruitNum = 3;
                break;

            case "Fruits4(Clone)":
                fruitNum = 4;
                break;

            case "Banana(Clone)":
                fruitNum = 4;
                break;

        }

        if (carrying == false)
        {
            if (Input.GetKeyDown(KeyCode.E) && (holdpoint.transform.position - transform.position).sqrMagnitude < range)
            {
                pickup();
                carrying = true;
            }

            Destroy(this.gameObject, 60f);
        }
        else if (carrying == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                drop();
                carrying = false;
            }

            if (Input.GetKey(KeyCode.R) && upperForce <= 250)
            {
                upperForce += 5;
            }
            if (Input.GetKeyUp(KeyCode.R))
            {
                throwy();
                carrying = false;
                upperForce = 0;
            }
        }

        if (carrying2 == false)
        {
            if (Input.GetKeyDown(KeyCode.O) && (holdpoint2.transform.position - transform.position).sqrMagnitude < range)
            {
                pickup2();
                carrying2 = true;
            }

            Destroy(this.gameObject, 60f);
        }
        else if (carrying2 == true)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                drop2();
                carrying2 = false;
            }

            if (Input.GetKey(KeyCode.P) && upperForce <= 250)
            {
                upperForce += 5;
            }
            if (Input.GetKeyUp(KeyCode.P))
            {
                throwy2();
                carrying2 = false;
                upperForce = 0;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        switch (col.gameObject.name)
        {

            case "Table":
                Destroy(this.gameObject);
                break;

        }
    }

    //Player

    void pickup()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        this.gameObject.transform.position = holdpoint.transform.position;
        this.gameObject.transform.rotation = holdpoint.transform.rotation;
        this.gameObject.transform.parent = postHold.transform;

        melempar = false;
    }
    void drop()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        this.gameObject.transform.parent = null;
        this.gameObject.transform.position = holdpoint.transform.position;
    }
    void throwy()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        this.gameObject.transform.parent = null;
        this.gameObject.transform.position = holdpoint.transform.position;

        this.gameObject.GetComponent<Rigidbody>().AddForce(postHold.transform.up * upperForce);
        this.gameObject.GetComponent<Rigidbody>().AddForce(postHold.transform.forward * throwForce);

        melempar = true;
    }


    //Player 2

    void pickup2()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        this.gameObject.transform.position = holdpoint2.transform.position;
        this.gameObject.transform.rotation = holdpoint2.transform.rotation;
        this.gameObject.transform.parent = postHold2.transform;
    }
    void drop2()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        this.gameObject.transform.parent = null;
        this.gameObject.transform.position = holdpoint2.transform.position;
    }
    void throwy2()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        this.gameObject.transform.parent = null;
        this.gameObject.transform.position = holdpoint2.transform.position;

        this.gameObject.GetComponent<Rigidbody>().AddForce(postHold2.transform.up * upperForce);
        this.gameObject.GetComponent<Rigidbody>().AddForce(postHold2.transform.forward * throwForce);
    }
}
