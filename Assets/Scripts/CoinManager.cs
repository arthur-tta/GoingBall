using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinManager : Singleton<CoinManager>
{
    [SerializeField] private TextMeshProUGUI coinTxt;

    private int coinCounter;


    private void Start()
    {
        ResetCoinCounter();
    }

    private void ResetCoinCounter()
    {
        coinCounter = 0;
        UpdateTextCoin();
    }


    public void AddCoin(int value)
    {
        coinCounter += value;
        UpdateTextCoin();
    }


    public bool SubCoin(int value)
    {
        if(value > coinCounter)
        {
            return false;
        }

        coinCounter -= value;
        return true;

    }






    private void UpdateTextCoin()
    {
        coinTxt.text = coinCounter.ToString();
    }
}
