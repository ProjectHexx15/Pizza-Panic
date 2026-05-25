using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Transform currentCheckpoint; // used to store the currently activated cehckpoint
    private HealthManager healthManager; // used to allow access to the health mananger script
    public bool isActive;
    public static PlayerRespawn instance;

    private void Awake()
    {
        healthManager = GetComponent<HealthManager>(); // gets the health manager script and stores it in healthmamager
        instance = this;
    } // end of awake


    private void Update()
    {
        if(healthManager.currentHealth <= 0) // if the player has lost all of their health
        {
            Respawn(); // call the respawn function when the player dies
            healthManager.currentLives--; // player looses a life
        }
    } // end of update

    public void Respawn()
    {
        transform.position = currentCheckpoint.position; // moves the player to the checkpoint spawn position
        healthManager.Respawn(); // calls the respawn function in the health manager
    } // end of respawn

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Checkpoint") // if the player collides with a checkpoint
        {
            currentCheckpoint = collision.transform; // set the current checkpoint to the last checkpoint the player touched
          
        }

    } // end of collision detection


} // end of class
