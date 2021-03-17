using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkFX : MonoBehaviour
{
    public AudioClip grassFX;
    public AudioClip rockFX;
    public AudioSource AudioSRC;
    private AudioClip actualFX;

    private void Step()
    {
        actualFX = grassFX;
        AudioSRC.PlayOneShot(actualFX);
    }
}
