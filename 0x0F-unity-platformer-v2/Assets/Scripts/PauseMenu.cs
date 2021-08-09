using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool pauseStatus = false;
    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;
    
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseStatus == false)
                Pause();
            else
                Resume();
        }
    }
    public void Pause()
    {
        pauseStatus = true;
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        paused.TransitionTo(0.1f);
    }
    public void Resume()
    {
        pauseStatus = false;
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        unpaused.TransitionTo(0.1f);
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        unpaused.TransitionTo(0.1f);
    }

    public void MainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void Options()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("PrevScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene(1);
    }

}