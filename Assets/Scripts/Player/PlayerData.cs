using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class PlayerData : Singleton<PlayerData>
{

    public List<SkinSO> skins = new List<SkinSO>();

    public SkinSO usedSkin;

    public List<MapSO> maps = new List<MapSO>();

    public MapSO usedMap;


    protected string saveFile = "";


    public int coins;
    
    public int level;

    public int hp;

    private void Awake(){
        Create();
    }


    private void Create(){
       saveFile = Application.persistentDataPath + "/save.bin";

        if (File.Exists(saveFile))
        {
            // If we have a save, we read it.
           Read();
        }
        else
        {
            // If not we create one with default data.
			NewSave();
        }

    }


    void NewSave(){
        skins.Clear();
        maps.Clear();

        coins = 0;
        level = 1;

        Save();


    }


    public void Save(){
        BinaryWriter w = new BinaryWriter(new FileStream(saveFile, FileMode.OpenOrCreate));

        w.Write(coins);

        w.Write(level);
        
        w.Close();
    }

    public void Read(){
        BinaryReader r = new BinaryReader(new FileStream(saveFile, FileMode.Open));

        coins = r.ReadInt32();
        level = r.ReadInt32();

        r.Close();
    }

    public void ClearSave()
    {
        File.Delete(Application.persistentDataPath + "/save.bin");
        Create();
    } 
}



