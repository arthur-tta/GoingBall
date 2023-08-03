using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public float timeToLive = 2f;

    private float timer;
    private bool isLive;

    public void Init(){
        gameObject.SetActive(true);
        timer = 0;
        isLive = true;
    }

    private void Update(){
        if(isLive){
            timer += Time.deltaTime;
            if(timer >= timeToLive){
                gameObject.SetActive(false);
                isLive = false;
            }
        }
    }
}
