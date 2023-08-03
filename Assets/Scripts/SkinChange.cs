using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChange : MonoBehaviour
{
    public List<SkinSO> listSkin = new List<SkinSO>();
    

    public SkinSO defaultSkin;

    private SkinSO skin;

    private SkinSO currentSkin;

    private int index;



    // Mesh and material

    private Renderer renderer;
    private MeshFilter meshFilter;

    private void Awake()
    {
        renderer = GetComponent<Renderer>();
        meshFilter = GetComponent<MeshFilter>();

        Init();
    }


    public void Init(){
        if(skin == null){
            skin = defaultSkin;
        }

        currentSkin = skin;
        index = currentSkin.hp - 1;

        //print(index);
        NewChangeSkin();
    }


    private void NewChangeSkin(){
        if(renderer != null && meshFilter != null){
            meshFilter.mesh = currentSkin.newMesh;
            renderer.material = currentSkin.newMaterial;
        }
    }


    public void ChangeSkin(){

        //  ("change skin");
        index--;
        if(index >= 0){
            currentSkin = listSkin[index];

            NewChangeSkin();
        }

        // TODO: game over

    }



    public void ResetData(){
        Init();
    }

    public void SetSkin(SkinSO skin){
        this.skin = skin;
        Init();
    }


}
