using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;

    void OnTriggerEnter(Collider other)
    {
            playerg.SetActive(false);
            player.position = destination.position;
            playerg.SetActive(true);
    }
}
