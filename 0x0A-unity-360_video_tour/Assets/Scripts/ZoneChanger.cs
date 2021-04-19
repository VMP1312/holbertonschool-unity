using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZoneChanger : MonoBehaviour
{
    public Animator animator;
    private int scene;

    public void Living()
    {
        animator.SetTrigger("FadeOut");
        scene = 0;
    }

    public void Cantina()
    {
        animator.SetTrigger("FadeOut");
        scene = 1;
    }

    public void Cube()
    {
        animator.SetTrigger("FadeOut");
        scene = 2;
    }

    public void Mezzanine()
    {
        animator.SetTrigger("FadeOut");
        scene = 3;
    }

    public void Change()
    {
        SceneManager.LoadScene(scene);
        animator.SetTrigger("FadeIn");
    }
}
