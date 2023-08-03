using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : Singleton<LevelManager>
{
   

    [SerializeField]
    private GameObject player;

    private Vector2 spawnPosition;

    public void SaveSpawnPositon(Vector3 position)
    {
        spawnPosition = position;
    }

    public void SpawnPlayer()
    {
        player.transform.position = spawnPosition;
    }
}
