using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public Transform target;

    private void Update()
    {
        transform.RotateAround(target.position, Vector3.up, 20 * Time.deltaTime);
    }
}
