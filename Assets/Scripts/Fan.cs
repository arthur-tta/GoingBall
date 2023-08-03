    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    [SerializeField] private float speed;

    private Vector3 rotationAxis = new Vector3(0, 1, 0);

    private void Update()
    {
        transform.Rotate(rotationAxis, speed * Time.deltaTime);
    }
}
