using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
  

    [SerializeField] private Transform[] points;

    [SerializeField] private float speed;

    private Transform nextPoint;
    private int index;


    private void Start()
    {
        nextPoint = points[index];
    }

    private void Update()
    {
        if(Vector3.Distance(nextPoint.position, transform.position) <= 0.1f)
        {
            index++;
            if(index == points.Length)
            {
                index = 0;
            }
            nextPoint = points[index];
        }

        transform.position = Vector3.MoveTowards(transform.position, nextPoint.position, speed * Time.deltaTime);
        
    }
}
