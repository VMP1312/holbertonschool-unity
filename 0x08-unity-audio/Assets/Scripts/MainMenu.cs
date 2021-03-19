using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;
    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
        unpaused.TransitionTo(0.1f);
    }
    public void Options()
    {
        SceneManager.LoadScene(1);
        PlayerPrefs.SetString("PrevScene", SceneManager.GetActiveScene().name);
    }
    public void QuitGame()
    {
        Debug.Log("Exited");
        Application.Quit();
    }

    public void Instructions()
    {
        SceneManager.LoadScene(5);
        PlayerPrefs.SetString("PrevScene", SceneManager.GetActiveScene().name);
    }
}
