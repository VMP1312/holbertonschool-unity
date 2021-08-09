using UnityEngine;

public class CutsceneController : MonoBehaviour
{
    Animator anim;
    public GameObject mainCamera;
    public GameObject player;
    public GameObject timerCanvas;
    public GameObject cutCamera;
    
    void awake()
    {
        anim = GetComponent<Animator>();
    }

    void StartGame()
    {
        cutCamera.SetActive(false);
        mainCamera.SetActive(true);
        timerCanvas.SetActive(true);
        player.gameObject.GetComponent<PlayerController>().enabled = true;
    }
}
