using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkFX : MonoBehaviour
{
    public AudioClip grassFX;
    public AudioClip rockFX;
    public AudioClip grassImpactFX;
    public AudioClip rockImpactFX;
    public GameObject player;
    public AudioSource WalkSRC;
    public AudioSource ThumpSRC;
    
    private RaycastHit hit;

    private void Step()
    {
        Debug.Log("RUN");
        Debug.DrawRay(transform.position,Vector3.down);
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            if (Physics.Raycast(player.transform.position, Vector3.down, out hit))
            {
                if (hit.collider.tag == "Grass")
                    WalkSRC.PlayOneShot(grassFX);

                if (hit.collider.tag == "Rock")
                    WalkSRC.PlayOneShot(rockFX);
            }
        }

    }

    private void Impact()
    {
        if (Physics.Raycast(player.transform.position, Vector3.down, out hit))
            {
                if (hit.collider.tag == "Grass")
                    ThumpSRC.PlayOneShot(grassImpactFX);

                if (hit.collider.tag == "Rock")
                    ThumpSRC.PlayOneShot(rockImpactFX);
            }
        }
}
