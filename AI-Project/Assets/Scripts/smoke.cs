using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    public GameObject chimney;
    
    public void OnTriggerEnter(Collider other)
    {
        chimney.SetActive(true);
        Destroy(gameObject);

    }
}
