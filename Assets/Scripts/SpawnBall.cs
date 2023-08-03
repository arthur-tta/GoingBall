using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] private BallSkin ballSkin;

    public Transform ring;


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
        meshBall.mesh = ballSkin.meshBall;
        meshBallMaterial.material = ballSkin.material;
        if (ballSkin.meshRing != null)
        {

            meshRing.mesh = ballSkin.meshRing;
            meshRingMaterial.material = ballSkin.material;
            ring.gameObject.SetActive(true);

            //if (ballSkin.isRotation)
            //{
            //    ring.gameObject.transform.Rotate()
            //}
        }
        else
        {
            //print(200);
            ring.gameObject.SetActive(false);

        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.gameObject.GetComponent<BallSkinChanger>().ChangeBallSkin(ballSkin.id);
            gameObject.SetActive(false);
        }
    }

}
