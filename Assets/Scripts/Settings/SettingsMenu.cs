using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject checkMar;

  public void invertY()
    {
        CameraMovement.invertY = !CameraMovement.invertY; // sets this value to its opposite state when button is pressed
        checkMar.SetActive(CameraMovement.invertY); // changes the active depending on the result of the yinvert bool
    } // end of invertY

} // end of class
