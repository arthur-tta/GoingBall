using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;
public class DataManager : MonoBehaviour
{   
    public TextMeshProUGUI coinText;

    
    #if UNITY_EDITOR

    private void Update(){
        if(Input.GetKeyDown(KeyCode.A)){
            PlayerData.Instance.coins += 100000;
            coinText.text = PlayerData.Instance.coins.ToString();
        }else if(Input.GetKeyDown(KeyCode.R)){
            PlayerData.Instance.ClearSave();
            coinText.text = PlayerData.Instance.coins.ToString();

        }
    }

    #endif
}
