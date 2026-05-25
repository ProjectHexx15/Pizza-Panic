using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformPlayer : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player") // if the platform triggers a collision with the player
        {
            other.transform.SetParent(transform); // attaches the player to the platform so they move with it
        }
    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player") // if the platform triggers a collision with the player
        {
            other.transform.SetParent(null); // attaches the player to the platform so they move with it
        }
    }


} // end of class
