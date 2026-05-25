using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    // NUMBER OF ITEMS
    public int coinCount; // used to determine how many COINS are in a level
    public int peppyCount; // used to determine how many PEPPYS are in a level
    public int enemyCount; // used to determine how many ENEMIES are in a level

    public GameManager manager; // allow access to game manager value - can see which level this is

    private void Start()
    {
        // inizialite the values
        coinCount = GameObject.FindGameObjectsWithTag("Coin").Length; // stores the amount of game objects in this level
        peppyCount = GameObject.FindGameObjectsWithTag("Peppy").Length;   // stores the amount of game objects in this level
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length; // stores the amount of game objects in this level
    } // end of start

    public void starsAchieved()
    {
        // find any remaining items NOT collected/defeated
        int coinsLeft = GameObject.FindGameObjectsWithTag("Coin").Length;
        int peppyLeft = GameObject.FindGameObjectsWithTag("Peppy").Length;
        int enemyLeft = GameObject.FindGameObjectsWithTag("Enemy").Length;

        // calculate how many where collected/defeated using this value
        int coinsCollected = coinCount - coinsLeft;
        int peppyCollected = peppyCount - peppyLeft;
        int enemyDefeated = enemyCount - enemyLeft;

        int totalAmount = coinCount + peppyCount + enemyCount; // calculates the total amount of items
        int collectedAmount = coinsCollected + peppyCollected + enemyDefeated; // calculates the total amount of items collected by player

        float percentage = float.Parse(collectedAmount.ToString()) / float.Parse(totalAmount.ToString()) * 100; // calculates the players collected item total

        PlayerPrefs.SetFloat("percentageCampaign" + manager.levelNumber, percentage); // stores the players collection percentage and saves it
    } // end of starsAchieved


} // end of class
    