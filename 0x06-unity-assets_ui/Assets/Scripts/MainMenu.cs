using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void LevelSelect(int level)
    {
        SceneManager.LoadScene(level);
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
}
