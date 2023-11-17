using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement: MonoBehaviour
{
    public NavMeshAgent mAgent;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouse = Input.mousePosition;

            Ray castPoint = Camera.main.ScreenPointToRay(mouse);

            RaycastHit hit;
            if (Physics.Raycast(castPoint, out hit, 100.0f))
            {
                mAgent.SetDestination(hit.point);
            }
        }

    }
}