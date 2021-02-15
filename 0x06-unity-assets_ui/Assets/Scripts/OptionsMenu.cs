using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public bool YAxisToggle;
    public Toggle toggle;
    private int isInverted;
    public CameraController cameraController;


    public void Back()
    {
        string getBack= PlayerPrefs.GetString("PrevScene");
        SceneManager.LoadScene(getBack);
    }

    public void Apply()
    {
        isInverted = toggle.isOn == true ? 1 : 0;
        PlayerPrefs.SetInt("isInverted", isInverted);
    }

    public void Inverter()
    
    {
        if (toggle.isOn)
            YAxisToggle = true;
        else
            YAxisToggle = false;
    }
}
