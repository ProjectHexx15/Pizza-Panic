using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerMechanic : MonoBehaviour
{
    // variables
    [SerializeField] TMP_Text timerText; // stores the timer text on the HUD
    public float currentTime; // current status of the timer
    public float maxTime; // used to reset the timer for each level

    // limit settings
    public float timerLimit; // will be used to determine when the timer has finished

    private void Start()
    {
       currentTime = maxTime; // resets the timer
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime; // decrements the timer

        if(currentTime <= timerLimit ) // if the timer has ran out
        {
            currentTime = timerLimit; // // set the timer to the limit 
            MenuManager.instance.GameOver(); // the timer has ran out and game is overw
        }

        timerText.text = currentTime.ToString("0"); //timer only has one decimal place

    } // end of update

    public void AddTime(float time)
    {
        currentTime += time; // adds time to the timer 
    }



} // end of class
