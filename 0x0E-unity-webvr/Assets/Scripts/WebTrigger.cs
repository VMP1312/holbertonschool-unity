using WebXR;
using Zinnia.Action;
using UnityEngine;

public class WebTrigger : BooleanAction
{

    public WebXRController controller;


    // Update is called once per frame
    void Update()
    {
        Receive(controller.GetButton(WebXRController.ButtonTypes.Grip) || controller.GetButton(WebXRController.ButtonTypes.Trigger));
    }
}
