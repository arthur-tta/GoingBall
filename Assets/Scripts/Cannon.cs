using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [SerializeField] private List<FireBall> fireBalls;

    [SerializeField] private Transform firePoint;

    [SerializeField] private float cooldown;


    private float timer = Mathf.Infinity;



    private void Update()
    {
        timer += Time.deltaTime;
        if(timer >= cooldown)
        {
            Fire();
            timer = 0;
        }
    }

    private void Fire()
    {
        int index = GetFireBall();

        fireBalls[index].transform.position = firePoint.position;
        fireBalls[index].Initialized(firePoint.position - transform.position);
    }


    private int GetFireBall()
    {
        for(int i = 0; i < fireBalls.Count; i++)
        {
            if (fireBalls[i].gameObject.activeInHierarchy)
            {
                continue;
            }
            return i;
        }
        return 0;
    }
}
