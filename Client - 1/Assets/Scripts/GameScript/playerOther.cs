using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;

public class playerOther : MonoBehaviour
{
    private NavMeshAgent nav;
    public receiveData recv;

    // Start is called before the first frame update
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //nav.SetDestination(new Vector3(recv.fruit.positX, recv.fruit.positY, recv.fruit.positZ));
        //Debug.Log(recv.player2.positX + " " + recv.player2.positY + " " + recv.player2.positZ);
    }
}
