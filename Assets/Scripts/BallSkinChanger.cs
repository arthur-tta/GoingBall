using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSkinChanger : MonoBehaviour
{
    public List<BallSkin> ballSkins;

    public Transform ring;

    public bool autoRotation;

    private BallSkin ballSkin;

    private MeshRenderer meshBallMaterial;
    private MeshRenderer meshRingMaterial;
    private MeshFilter meshBall;
    private MeshFilter meshRing;

    private void Awake()
    {
        meshBallMaterial = GetComponent<MeshRenderer>();
        meshBall = GetComponent<MeshFilter>();


        meshRing = ring.gameObject.GetComponent<MeshFilter>();
        meshRingMaterial = ring.gameObject.GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        ChangeBallSkin(2);

    }


    public void ChangeBallSkin(int id)
    {
        ballSkin = GetBallSkin(id);
        meshBall.mesh = ballSkin.meshBall;
        meshBallMaterial.material = ballSkin.material;
        if (ballSkin.meshRing != null)
        {
            
            meshRing.mesh = ballSkin.meshRing;
            meshRingMaterial.material = ballSkin.material;
            ring.gameObject.SetActive(true);

            
        }
        else
        {
            //print(200);
            ring.gameObject.SetActive(false);

        }

        //print(3);
        if (ballSkin.autoRotation != autoRotation)
        {
            ring.gameObject.transform.rotation = Quaternion.identity;
        }
        autoRotation = ballSkin.autoRotation;


    }

    private BallSkin GetBallSkin(int id)
    {
        foreach (var item in ballSkins)
        {
            if (item.id == id)
            {
                return item;
            }
        }
        return ballSkins[0];
    }

    private void Update()
    {
        if (autoRotation)
        {
            ring.gameObject.transform.Rotate(Vector3.up);
        }
        else if(ballSkin.meshRing != null)
        {
            ring.gameObject.transform.Rotate(Vector3.right * 2);
        }
    }










    /*

      private void ChangeSkin()
      {
          meshFilter.mesh = targetRender;
          meshRenderer.material = targetMaterial;
      }*/
}
