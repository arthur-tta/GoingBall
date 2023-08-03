using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatePortal : MonoBehaviour
{
    public GameObject barie;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //print("Zoo");
            other.GetComponent<SaveGame>().Win();
            
            
        }
    }


  
}
