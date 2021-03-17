using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool pauseStatus = false;
    
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
    }
    public void Resume()
    {
        pauseStatus = false;
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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