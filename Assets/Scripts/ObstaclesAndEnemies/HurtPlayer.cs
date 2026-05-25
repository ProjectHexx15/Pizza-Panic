using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    // variables
    public int damageValue; // how much damage the attacker does

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player") // if the object collides with the player
        {
            Vector3 hitDirection = collision.transform.position - transform.position; // gets the opposite of the players direction so can apply the knockback force
            hitDirection = hitDirection.normalized; // restricts the hittdirection to be in a straight line distance - ensures knockback is consistant

            FindObjectOfType<HealthManager>().TakeDamage(damageValue, hitDirection); // acess the health manager and take damage apply hit direction to the players knockback
        }
    } // end of collision detection


} // end of class
