using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelePosition : MonoBehaviour
{
    [SerializeField] private Transform nextGate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.position = nextGate.transform.position;
        }
    }
}
