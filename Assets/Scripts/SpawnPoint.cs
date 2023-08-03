using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private GameObject spawnBall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            spawnBall.SetActive(false);
            LevelManager.Instance.SaveSpawnPositon(transform.position + new Vector3(0, 1, 0));
        }
    }
}
