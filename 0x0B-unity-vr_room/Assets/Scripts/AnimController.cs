using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public Animator anim;

    public Keypad keypad;
    bool isOpen = false;

   public void DoorControl()
    {
        if(keypad.pswdStatus)
        {
            if(!isOpen)
            {
                anim.Play("glass_door_open");
                isOpen = true;
            }
            else
            {
                anim.Play("glass_door_close");
                isOpen = false;
            }
        }
    }
}
