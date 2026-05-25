using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerItem : MonoBehaviour
{
    // variables
    [SerializeField] TimerMechanic timerMechanic; // allows access to the timer mechanic script
    [SerializeField] float timeToAdd; // stores how many seconds to add to the timer

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player") // ensures only player can collect timers
        {
            timerMechanic.AddTime(timeToAdd); // adds the specified amount of time to the timer
            Destroy(this.gameObject); // destroys the timer after it is collected
        }
       
    } // end of trigger detection


} // end of class
