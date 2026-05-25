using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VentLaunch : MonoBehaviour
{
    public int launchForce;
    public static VentLaunch instance; // creates a public static version of this script

    void awake()
    {
        instance = this; // allows access to this script from other ones
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // if the player collides with the vent
        {
            PlayerController.instance.launchPlayer(launchForce); // call the launch player function
        }


    } // end of collision detection


} // end of class
