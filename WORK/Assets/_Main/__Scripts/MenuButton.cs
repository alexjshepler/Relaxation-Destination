using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///Summary:
/// This script gets put into each world so you could press the back button and go back to the scene called _MenuScene
public class MenuButton : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.Back))
        {
            SceneManager.LoadScene("_MenuScene");
        }
    }
}
