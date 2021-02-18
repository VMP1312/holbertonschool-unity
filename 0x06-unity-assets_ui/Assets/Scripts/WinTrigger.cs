using UnityEngine;
using UnityEngine.UI;
public class WinTrigger : MonoBehaviour
{
    public GameObject player;
    public Text TimerText;
    public GameObject WinCanvas;
    private void OnTriggerEnter(Collider other) 
    {
        player.GetComponent<Timer>().enabled = false;
        //TimerText.fontSize = 80;
        //TimerText.color = Color.green;
        player.GetComponent<Timer>().Win();
        WinCanvas.SetActive(true);
    }
}