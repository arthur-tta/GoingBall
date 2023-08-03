using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    private SkinChange skinChange;

    private PickUpSystem pickUpSystem;

    private int hp;


    // save game parametter

    private PlayerMovement playerMovement;

    private Vector3 spawnPoint;


    private void Awake(){
        skinChange = GetComponent<SkinChange>();
        playerMovement = GetComponentInParent<PlayerMovement>();
        pickUpSystem = GetComponentInParent<PickUpSystem>();


        Init();

    }

    private void Init(){
        hp = PlayerData.Instance.hp;

        spawnPoint = transform.position;
    }




    public void UpdateSpawnPoint(Vector3 position)
    {
        spawnPoint = position;
    }


    public void Death(){
        hp--;

        //print("zo");
        skinChange.ChangeSkin();
        playerMovement.ResetMovement(spawnPoint);


        

        if(hp <= 0){
            GameOver();
        }
    }

    private void GameOver(){
        
    }


    public void Win()
    {
        print("Zee");
        pickUpSystem.WinGame();
    }

}
