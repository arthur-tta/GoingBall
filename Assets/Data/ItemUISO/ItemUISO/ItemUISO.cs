using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemUISO", menuName = "ItemUISO", order = 1)]

public class ItemUISO : ScriptableObject
{
   public Sprite icon;

   public string name;

   public int cost;

   public bool purchased;
}
