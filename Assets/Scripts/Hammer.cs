using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : MonoBehaviour
{
    [SerializeField] private bool zAxis;
    [SerializeField] private bool yAxis;

    [SerializeField] private float rotation;

    [SerializeField] private float rotationSpeed = 5f;

    [SerializeField] private bool isSymmetry;

    private Vector3 rotationAxis;

    

    private void Start()
    {
        if (zAxis)
        {
            rotationAxis = new Vector3(0, 0, 1);
        }else if (yAxis)
        {
            rotationAxis = new Vector3(0, 1, 0);

        }
    }


    private void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
        if (yAxis)
        {
            // quay doi xung
            if (isSymmetry)
            {
                //print(transform.rotation.eulerAngles.y);
                if (transform.rotation.eulerAngles.y >= rotation / 2
                    && transform.rotation.eulerAngles.y <= (360 - rotation / 2))
                {
                    rotationAxis = -rotationAxis;
                }
            }
            else // quay goc (0,rotation)
            {
                if(transform.rotation.eulerAngles.y >= rotation
                    && transform.rotation.eulerAngles.y <= 360)
                {
                    rotationAxis = -rotationAxis;
                }
            }

        }
        else
        {
            // quay doi xung
            if (isSymmetry)
            {
                //print(transform.rotation.eulerAngles.y);
                if (transform.rotation.eulerAngles.z >= rotation / 2
                    && transform.rotation.eulerAngles.z <= (360 - rotation / 2))
                {
                    rotationAxis = -rotationAxis;
                }
            }
            else // quay goc (0,rotation)
            {
                if (transform.rotation.eulerAngles.z >= rotation
                    && transform.rotation.eulerAngles.z <= 360)
                {
                    rotationAxis = -rotationAxis;
                }
            }
        }
        
        
     



    }
}
