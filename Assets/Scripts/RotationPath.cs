using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPath : MonoBehaviour
{
    [SerializeField] private float rotation;

    [SerializeField] private float speed;

    [SerializeField] private bool xAxis;
    [SerializeField] private bool yAxis;
    [SerializeField] private bool zAxis;

    private Vector3 rotationAxis;

    private void Awake()
    {
        if (xAxis)
        {
            rotationAxis = new Vector3(1, 0, 0);
        }else if (yAxis)
        {
            rotationAxis = new Vector3(0, 1, 0);
        }
        else if (zAxis)
        {
            rotationAxis = new Vector3(0, 0, 1);
        }
    }

    private void Update()
    {
        //transform.Rotate(rotationAxis, speed * Time.deltaTime);

        if (zAxis)
        {
            transform.Rotate(rotationAxis, speed * Time.deltaTime);

            if (transform.rotation.eulerAngles.z >= rotation / 2
                    && transform.rotation.eulerAngles.z <= (360 - rotation / 2))
            {
                rotationAxis = -rotationAxis;
            }
        }else if (xAxis)
        {
            transform.Rotate(rotationAxis, speed * Time.deltaTime);

            if (transform.rotation.eulerAngles.x >= rotation / 2
                    && transform.rotation.eulerAngles.x <= (360 - rotation / 2))
            {
                rotationAxis = -rotationAxis;
            }
        }
        else if (yAxis)
        {
            transform.Rotate(rotationAxis, speed * Time.deltaTime);

            if (transform.rotation.eulerAngles.y >= rotation / 2
                    && transform.rotation.eulerAngles.y <= (360 - rotation / 2))
            {
                rotationAxis = -rotationAxis;
            }
        }
    }



}
