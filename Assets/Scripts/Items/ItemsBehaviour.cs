using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsBehaviour : MonoBehaviour
{
    // variables
    public Camera playerCam; // stores the camera object
    public int value; // stores the value of the coin
    private AudioManager audioManger; // used to add sound to the player

    private void Awake()
    {
        audioManger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); // finds the audio manager and stores its AM component
    } // end of awake

    void Start()
    {
        playerCam = Camera.main; // finds the player camera
    } // end of start

    private void Update()
    {
        transform.LookAt(playerCam.transform.position); // makes the 
    
    } // end of update

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") // if the item collides with the player
        {
            if(this.gameObject.tag == "Coin") // if the player collideds with the coin
            {
                // find the game manager
                FindObjectOfType<GameManager>().AddCoin(10); // add ten points to the players coin count
                audioManger.PlaySFX(audioManger.collectCoin);
            }
            else if(this.gameObject.tag == "Peppy") // if the player has collided with the cola
            {
                FindObjectOfType<HealthManager>().AddHealth(1); // the player recieves one health point for drinking cola
                FindObjectOfType<GameManager>().AddCoin(15); // add fifteen points to the players coin count for collecting a cola
                audioManger.PlaySFX(audioManger.drinkPeppy);
            }


            Destroy(this.gameObject); // destroy the item once its collected
        }


    } // end of trigger detection

} // end of class
