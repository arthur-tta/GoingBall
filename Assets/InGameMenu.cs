using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class InGameMenu : MonoBehaviour
{
    public void OpenShop()
    {
        SceneManager.LoadScene("Shop");
    }
}
