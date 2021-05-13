using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointerClick()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1.8f, transform.position.z);
    }

    public void PointerClickFix()
    {
        player.transform.position = new Vector3(transform.position.x + 1f, transform.position.y + 1.8f, transform.position.z + 1);
    }

    public void PointerClickconsole()
    {
        player.transform.position = new Vector3(transform.position.x , transform.position.y + 1.8f, transform.position.z - 1f);
    }



}
