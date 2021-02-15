using UnityEngine;
public class TimerTrigger : MonoBehaviour
{
    public GameObject player;
    
    private void OnTriggerExit(Collider other) 
    {
       player.GetComponent<Timer>().enabled = true;
    }
}
