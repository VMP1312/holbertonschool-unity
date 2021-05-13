using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleManager : MonoBehaviour
{
    public GameObject console;
    bool status;

    void Start()
    {
        console.SetActive(false);
        status = false;
    }

    public void statuscontrol()
    {
        if (!status)
        {
            console.SetActive(true);
            status = true;
        }
        else
        {
            console.SetActive(false);
            status = false;
        }
    }
}
