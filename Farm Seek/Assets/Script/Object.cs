using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private GameObject postHold;
    private Transform holdpoint;
    private GameObject postHold2;
    private Transform holdpoint2;
    public float range = 0.1f;
    public float throwForce = 800;
    public float upperForce;
    bool carrying;
    public float fruitNum;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        postHold = GameObject.FindGameObjectWithTag("hold");
        holdpoint = postHold.GetComponent<Transform>();
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
            if (Input.GetKeyDown(KeyCode.K) && (holdpoint.transform.position - transform.position).sqrMagnitude < range)
            {
                pickup();
                carrying = true;
            }

            Destroy(this.gameObject, 60f);
        }
        else if (carrying == true)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                drop();
                carrying = false;
            }

            if (Input.GetKey(KeyCode.L) && upperForce <= 250)
            {
                upperForce += 5;
            }
            if (Input.GetKeyUp(KeyCode.L))
            {
                throwy();
                carrying = false;
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

    void pickup()
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = false;
        this.gameObject.GetComponent<Rigidbody>().isKinematic = true;
        this.gameObject.transform.position = holdpoint.transform.position;
        this.gameObject.transform.rotation = holdpoint.transform.rotation;
        this.gameObject.transform.parent = postHold.transform;
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
    }
}
