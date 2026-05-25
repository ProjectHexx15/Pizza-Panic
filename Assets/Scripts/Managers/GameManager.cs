using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // variables
    public int currentCoins; // stores the current amount of coins that the player has
    public TMP_Text cointCount; // text that displays the current coint count
    public TMP_Text livesCount; // this text displays the players current live count
    public Slider staminaSlider; // stores the stamina slider on the UI
    public int levelNumber; // used to determine the current level, so the score can be saved for each leve


    private void Update()
    {
        staminaSlider.value = PlayerController.instance.sprintTimer; // updates the stamina slider using the value of the sprint timer
        livesCount.text = HealthManager.instance.currentLives.ToString();   // updates the players life count
        PlayerPrefs.GetInt("score" +  levelNumber, currentCoins); // gets the current score for this level
    }

    public void AddCoin(int coinToAdd) // takes in the coin to add value
    {
        currentCoins += coinToAdd; // adds the amount of coins to add to the current amont
        cointCount.text = currentCoins.ToString();

    } // end of add coin
    public void SaveScore()
    {
        PlayerPrefs.SetInt("score" + levelNumber, currentCoins); // saves the players score
    } // end of save score

      
} // end of class
