using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class OptionsMenu : MonoBehaviour
{
    public Toggle toggle;
    public Button BackButton;
    public Button ApplyButton;
    public AudioMixer mixer;
    public Slider BGM;
    public Slider SFX;
    private int isInverted;
    private float bgmv;
    private float sfxv;
    private float Savedbgm;
    private float Savedsfx;
    
    public void Start()
    {
        bgmv = PlayerPrefs.GetFloat("BGM", 1f);
        Savedbgm = bgmv;
        BGM.value = bgmv;
        sfxv = PlayerPrefs.GetFloat("sfx", 1f);
        Savedsfx = sfxv;
        SFX.value = sfxv;

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
        PlayerPrefs.SetFloat("BGM", Savedbgm);
        PlayerPrefs.SetFloat("SFX", Savedsfx);
        SceneManager.LoadScene(getBack);
    }

    public void Apply()
    {
        isInverted = toggle.isOn == true ? 1 : 0; 
        PlayerPrefs.SetInt("isInverted", isInverted);
        PlayerPrefs.SetFloat("BGM", bgmv);
        PlayerPrefs.SetFloat("SFX", sfxv);
    }
    public void BGMSlider()
    {
        bgmv = BGM.value;
        mixer.SetFloat("BGMvolume", Mathf.Log10(BGM.value) * 20);
    }
    public void SFXSlider()
    {
        sfxv = SFX.value;
        mixer.SetFloat("SFXvolume", Mathf.Log10(SFX.value) * 20);
    }

    public void KeyB()
    {
        SceneManager.LoadScene(6);
        PlayerPrefs.SetString("PrevScene", SceneManager.GetActiveScene().name);
    }
}
