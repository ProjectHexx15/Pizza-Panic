using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    // variables
    public int currentHealth; // stores how much health the player has currently
    public int maxHealth = 3; // stores the players maximum amount of health
    public Image[] playerPizza; // an array that stores the pizza images

    public int currentLives; // stores how many lives the player has currently
    private int maxLives = 3; // stores the players maximum amount of lives

    public float invincibilityLength; // stores how long the player should be invinsible for after being attacked
    public float invincibilityCounter; // used to determine if the player should be invincible or not


    public static HealthManager instance; // allows other scripts to access this one
    private AudioManager audioManger; // used to add sound to the player

    private void Awake()
    {
        instance = this;
        audioManger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); // finds the audio manager and stores its AM component
    } // end of awake

    private void Start()
    {
        currentHealth = maxHealth; // resets the players health to max at the begining of the match
        currentLives = maxLives; // resets the players lives to the max at the begining of the match
    } // end of start

    private void Update()
    {
        if(invincibilityCounter > 0) // if the invinsibilty counter is set greater than 0
        {
            invincibilityCounter -= Time.deltaTime; // derement the invincibility timer
            
        }
        if(currentHealth > maxHealth) // if the player exceeds their health limit
        {
            currentHealth = maxHealth; // reset the health back to the max
        }
    } // end of update

    public void TakeDamage(int damage, Vector3 direction) // this function damages the player depending on what hurts them
    {
        if (invincibilityCounter <= 0) // if the player is NOT incinvisble - counter has finished
        {
            currentHealth -= damage; // player looses health

            audioManger.PlaySFX(audioManger.playerhurt);

            PlayerController.instance.Knockback(direction); // calls the knockback player function

            invincibilityCounter = invincibilityLength; // resets the invincibilty counter

            healthUpdate(); // update players health when they are damaged
        }
  
    } // end of TakeDamage

    public void AddHealth(int health)
    {
        currentHealth += health; // adds the amount of health recieved
        healthUpdate(); // updates the players health
    } // end of addHealth

    public void Respawn()
    {
        AddHealth(maxHealth); // resets the players lives when they respawn

    } // end of respawn 

    public void healthUpdate()
    {
        if(currentHealth == maxHealth) // if the player has all of their health
        {
            playerPizza[0].enabled = true; // first slice is enabled
            playerPizza[1].enabled = true; // second slice is enabled
            playerPizza[2].enabled = true; // third slice is enabled
        }
        else if(currentHealth == 2) // if the player has lost one slice
        {
            playerPizza[0].enabled = false; // first slice is NOT enabled
            playerPizza[1].enabled = true; // second slice is enabled
            playerPizza[2].enabled = true; // third slice is enabled
        }
        else if(currentHealth == 1) // if the player has lost two slices
        {
            playerPizza[0].enabled = false; // first slice is NOT enabled
            playerPizza[1].enabled = false; // first slice is NOT enabled
            playerPizza[2].enabled = true; // third slice is enabled
        }
        else if(currentHealth <= 0)
        {
            playerPizza[0].enabled = false; // first slice is NOT enabled
            playerPizza[1].enabled = false; // first slice is NOT enabled
            playerPizza[2].enabled = false; // first slice is NOT enabled
        }

        if (currentLives <= 0) // if the player has lost all of their lives
        {
            audioManger.PlaySFX(audioManger.loose);
            MenuManager.instance.GameOver(); // activates the game over screen when the player dies

        }
    } // end of healthUpdate

} // end of class
