using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class SkinItemUI : MonoBehaviour
{

    private SkinSO skin;

    public Image icon;

    public TextMeshProUGUI costTxt;

    public TextMeshProUGUI nameTxt;

    public Button buyButton;
    public Button changeButton;


    [Header("Shop Skin")]
    public ShopSkinList shopSkin;



    [Header("Game Object")]
    public GameObject changeSkin;
    public GameObject buySkin;






    public void Init(SkinSO item){

        skin = item;


        icon.GetComponent<Image>().sprite = skin.itemUISO.icon; 
        costTxt.text = skin.itemUISO.cost.ToString();
        nameTxt.text = skin.itemUISO.name;

        skin.itemUISO.purchased = false;


        CheckPurchased();
    }

    private void CheckPurchased()
    {
        if(skin.itemUISO.purchased){
            changeSkin.SetActive(true);
            buySkin.SetActive(false);
        }else{
            changeSkin.SetActive(false);
            buySkin.SetActive(true);
        }
        
    }

    public int GetCost(){
        
        return skin.itemUISO.cost;
    
    }

 


    public void Buy(){
        // check money
        
        if(shopSkin.BuySkin(this)){
            skin.itemUISO.purchased = true;
            CheckPurchased();
            
            //TODO: update data
        }   
    }

    public void ChangeSkin(){
        if(shopSkin.ChangeSkin(this)){


            // TODO: change skin
        }

    }


   
}
