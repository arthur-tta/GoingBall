using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncingObject : MonoBehaviour
{
    private Rigidbody rigidbody;

    

    [SerializeField] private float bounceForce;
    [SerializeField] private bool hasBackForce;
    [SerializeField] private float backForce;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 direction = - collision.contacts[0].point + transform.position;
            direction = direction.normalized;
            rigidbody.AddForce(direction * bounceForce, ForceMode.Impulse);
            if (hasBackForce)
            {
                print("hey!00");
                Rigidbody rb = collision.collider.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    direction = collision.contacts[0].point - transform.position;
                    direction = direction.normalized;
                    rb.AddForce(direction * backForce, ForceMode.Impulse);
                }
            }
        }
    }
}
