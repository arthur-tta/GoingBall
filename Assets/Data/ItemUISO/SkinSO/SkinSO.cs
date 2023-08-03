using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SkinSO", menuName = "UISO/SkinSO", order = 1)]


public class SkinSO : ScriptableObject
{
    public ItemUISO itemUISO;

    [Header("Skin Parameter")]
    public int hp;

    public Mesh newMesh;
    
    public Material newMaterial;

}
