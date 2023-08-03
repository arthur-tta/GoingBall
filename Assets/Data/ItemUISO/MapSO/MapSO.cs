using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "MapSO", menuName = "UISO/MapSO", order = 1)]


public class MapSO : ScriptableObject
{
    public ItemUISO itemUISO;

    [Header("Map Parameter")]
    public int test;
}
