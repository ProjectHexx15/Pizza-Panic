using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GodMode : MonoBehaviour
{
    public void addLives()
    {
        HealthManager.instance.maxHealth++;
        HealthManager.instance.currentLives++;
    } // end of add health

} // end of class
