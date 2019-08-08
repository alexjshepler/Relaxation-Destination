using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///Summary:
/// This tests to see if the touchpad gets pressed
public class TestListener : MonoBehaviour
{
    private void Awake()
    {
        PlayerEvents.OnControllerSource += Test;
        PlayerEvents.OnTouchpadDown += ProcessTouchpadDown;
        PlayerEvents.OnTouchpadUp += ProcessTouchpadUp;
    }

    private void OnDestroy()
    {
        PlayerEvents.OnControllerSource -= Test;
        PlayerEvents.OnTouchpadDown -= ProcessTouchpadDown;
        PlayerEvents.OnTouchpadUp -= ProcessTouchpadUp;
    }

    private void Test(OVRInput.Controller controller, GameObject controllerObject)
    {
        Debug.Log("Current Controller: " + controller.ToString());
        Debug.Log("Current Anchor: " + controllerObject.ToString());
    }

    private void ProcessTouchpadDown()
    {
        Debug.Log("Touchpad Down");
    }

    private void ProcessTouchpadUp()
    {
        Debug.Log("Touchpad Up");
    }
}