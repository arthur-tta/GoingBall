using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMapList : ShopList
{
    public List<MapItemUI> listItemUI;
    public List<MapSO> listItemSO;


    private void Start(){
        Init();
    }

    private void Init(){
        for(int i = 0; i < listItemSO.Count; i++){
            listItemUI[i].Init(listItemSO[i]);
        }
    }
}
