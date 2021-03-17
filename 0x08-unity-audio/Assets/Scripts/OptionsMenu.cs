using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public Toggle toggle;
    public Button BackButton;
    public Button ApplyButton;
    private int isInverted;
    public void Start()
    {
        try
        {
            toggle.isOn = PlayerPrefs.GetInt("isInverted") == 1 ? true : false;
        }
        catch (System.Exception)
        {
            throw;
        }

        BackButton.onClick.AddListener(() => Back());
        ApplyButton.onClick.AddListener(() => Apply());
    }
    public void Back()
    {
        string getBack = PlayerPrefs.GetString("PrevScene");
        SceneManager.LoadScene(getBack);
    }

    public void Apply()
    {
        isInverted = toggle.isOn == true ? 1 : 0; 
        PlayerPrefs.SetInt("isInverted", isInverted);
    }
}
