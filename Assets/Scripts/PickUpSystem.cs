using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PickUpSystem : MonoBehaviour
{
    public TextMeshProUGUI coinTextInGame;

    private int totalCoin;

    private void Awake()
    {
        UpdateCoinText();
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            other.gameObject.SetActive(false);

            totalCoin += 10;
            UpdateCoinText();
        }
    }


    private void UpdateCoinText()
    {
        coinTextInGame.text = totalCoin.ToString();
    }

    public void LoseGame()
    {
        totalCoin = 0;
        UpdateCoinText();
    }

    public void WinGame()
    {
        PlayerData.Instance.coins += totalCoin;
        totalCoin = 0;
        UpdateCoinText();
    }
}
