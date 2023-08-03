using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MonoBehaviour
{
    private Rigidbody rigidbody;

    [SerializeField] private float speed;
    [SerializeField] private float timeToLive;

    private float timer;
    private Vector3 movement;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        gameObject.SetActive(false);
    }



    public void Initialized(Vector3 movement)
    {
        gameObject.SetActive(true);
        timer = 0;

        this.movement = movement.normalized;
        rigidbody.velocity = Vector3.zero;
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeToLive)
        {
            gameObject.SetActive(false);
        }

        rigidbody.velocity += movement * speed * Time.deltaTime;
    }
}
