using UnityEngine;
using UnityEngine.SceneManagement;


public class ShopUI : MonoBehaviour
{
    /*
        Data
    */

    public ShopMapList mapList;

    public ShopSkinList skinList;


    protected ShopList m_OpenList;


    private void Start(){
        m_OpenList = skinList;
    }


    public void OpenSkinList(){
        m_OpenList.Close();
        m_OpenList = skinList;
        m_OpenList.Open();

    }

    public void OpenMapList(){
        m_OpenList.Close();
        m_OpenList = mapList;
        m_OpenList.Open();
    }

    public void CloseShop(){
        gameObject.SetActive(false);
        SceneManager.LoadScene("Main Scene");
    }

}
