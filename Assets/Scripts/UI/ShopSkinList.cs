using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ShopSkinList : ShopList
{
    public List<SkinItemUI> listItemUI;
    public List<SkinSO> listItemSO;

    [Header("Coin Text")]
    public TextMeshProUGUI coinText;

    [Header("Dialog")]
    public Dialog buySuccess;
    public Dialog buyFail;
    public Dialog changeSuccess;
    public Dialog changeFail;

    private void Start(){
        Init();
    }

    private void Init(){
        for(int i = 0; i < listItemSO.Count; i++){
            listItemUI[i].Init(listItemSO[i]);
        }

        UpdateCoinTxt(PlayerData.Instance.coins);
    }

    public bool BuySkin(SkinItemUI product){
        int cost = product.GetCost();
        if(PlayerData.Instance.coins >= cost){
            UpdateCoinTxt(PlayerData.Instance.coins -= cost);
            PlayerData.Instance.Save();

            buySuccess.Init();

            return true;
        }

        buyFail.Init();
        return false;
    }


    public bool ChangeSkin(SkinItemUI product){
        if(true){

            changeSuccess.Init();
            return true;
        }

        changeFail.Init();
        return false;
    }   


    private void UpdateCoinTxt(int value){
        coinText.text = value.ToString();
    }
}
