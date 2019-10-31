using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    private GameObject postHold;
    private Transform holdpoint;
    public float range = 5;
    public float throwForce = 800;
    public float upperForce;
    bool carrying;

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
        if (carrying == false)
        {
            if (Input.GetKeyDown(KeyCode.K) && (holdpoint.transform.position - transform.position).sqrMagnitude < range / range)
            {
                pickup();
                carrying = true;
            }
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
