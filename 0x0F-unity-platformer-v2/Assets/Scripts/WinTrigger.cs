using UnityEngine;
using UnityEngine.UI;
public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;
    public GameObject WinCanvas;
    public AudioSource BGMsource;
    public AudioSource Winsource;
    private void OnTriggerEnter(Collider other) 
    {
        player.GetComponent<Timer>().enabled = false;
        player.GetComponent<Timer>().Win();
        WinCanvas.SetActive(true);
        BGMsource.Pause();
        Winsource.Play();
    }

}