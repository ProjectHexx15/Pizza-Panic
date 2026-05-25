using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointActive : MonoBehaviour
{
    private PlayerRespawn instance; // allows acess to the player respawn script
    public ParticleSystem confetti; // stores the conffetti particle system

    private void Update()
    {
        if(this.gameObject.transform == PlayerRespawn.instance.currentCheckpoint) // if this checkpoint is the activated one
        {
            confetti.gameObject.SetActive(true); // display the confeti particle system
        }
        else
        {
            confetti.gameObject.SetActive(false); // de activate the particle system
        }
    } // end of update


} // end of class
