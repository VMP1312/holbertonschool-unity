using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class backbtn : MonoBehaviour
{
    public Button BackButton;

    public void Back()
    {
        string getBack = PlayerPrefs.GetString("PrevScene");
        SceneManager.LoadScene(getBack);
    }

}
