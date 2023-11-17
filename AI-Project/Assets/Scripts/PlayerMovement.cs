using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement: MonoBehaviour
{
    public NavMeshAgent mAgent;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;
            Vector3 stop = new Vector3(rb.velocity.x, 0, 0);

            Ray castPoint = Camera.main.ScreenPointToRay(mouse);

            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit, 100.0f))
            {
                mAgent.SetDestination(hit.point);
            }
        }

    }
}