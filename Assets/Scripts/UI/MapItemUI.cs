using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapItemUI : MonoBehaviour
{
    
    private MapSO map;

    public Image icon;

    public TextMeshProUGUI costTxt;

    public TextMeshProUGUI nameTxt;

    public Button buyButton;
    public Button changeButton;



    [Header("Game Object")]
    public GameObject changeSkin;
    public GameObject buySkin;



    public void Init(MapSO item){

        map = item;


        icon.GetComponent<Image>().sprite = map.itemUISO.icon; 
        costTxt.text = map.itemUISO.cost.ToString();
        nameTxt.text = map.itemUISO.name;


       CheckPurchased();
    }

    private void CheckPurchased()
    {
        if(map.itemUISO.purchased){
            changeSkin.SetActive(true);
            buySkin.SetActive(false);
        }else{
            changeSkin.SetActive(false);
            buySkin.SetActive(true);
        }
        
    }

 


    public void Buy(){
        // check money
        
        if(true){
            map.itemUISO.purchased = true;
            CheckPurchased();

            print(1);
            //TODO: update skin nhan vat
        }   
    }

    public void ChangeSkin(){
        // TODOL: update skin nhan vat
            print(2);

    }
    
}
