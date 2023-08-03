using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopTrap : MonoBehaviour
{
    [SerializeField] private float timeToPop;

    [SerializeField] private float force;

    private float timer;

    private Collider player;

    private bool start;

    private void Update()
    {
        if (start)
        {
            timer += Time.deltaTime;
            if(timer >= timeToPop)
            {
                timer = 0;
                Pop(); 
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            start = true;
            player = other;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            start = false;
            player = null;
            timer = 0;
        }
    }



    private void Pop()
    {
        if(player != null)
        {
            Rigidbody rb = player.GetComponent<Rigidbody>();
            if(rb != null)
            {
                //Vector3 direction = player.transform.position - transform.position;
                //direction = direction.normalized;
                Vector3 direction = new Vector3 (0, 1, 0);
                rb.AddForce(direction * force, ForceMode.Impulse);
                print("Booom!");
            }
        }
    }
}
