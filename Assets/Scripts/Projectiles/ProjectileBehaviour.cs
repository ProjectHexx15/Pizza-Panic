using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    // variables
    public float speed; // stores the speed that the projetile will move at
    private Transform _playerAttackPoint; // stores the transform position of the player
    private Vector3 _target; // used to determine where the projectile should move to
    public GameObject playerObj; // used to knockback the player when they are hit by enemy
    private Camera _playerCam; // stores player camera
    public int damageValue; // how much damage the attacker does


    private void Start()
    {
        // initialize
        _playerAttackPoint = GameObject.FindGameObjectWithTag("Target").transform; // finds the target and stores its transform position
        _playerCam = Camera.main; // finds the player camera
        _target = new Vector3(_playerAttackPoint.position.x, _playerAttackPoint.position.y, _playerAttackPoint.position.z); // stores the vector 3 coordinate of the target - the player
        playerObj = GameObject.Find("Liam"); // finds the transform position of the player and stores it in this variable
    } // end of start

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target, speed * Time.deltaTime); // move towards the player at the specified speed

        if(transform.position.x == _target.x && transform.position.y == _target.y && transform.position.z == _target.z) // if the projectile reaches the player
        {
            DestroyProjectile(); // cal the destroy projectile function
        }

        transform.LookAt(_playerCam.transform.position); // makes the projectile always face the players camera

    } // end of update

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player") // if the projetile hits player
        {
            DestroyProjectile(); // cal the destroy projectile function
            Vector3 hitDirection = playerObj.transform.position - transform.position; // gets the opposite of the players direction so can apply the knockback force
            hitDirection = hitDirection.normalized; // restricts the hittdirection to be in a straight line distance - ensures knockback is consistant

            FindObjectOfType<HealthManager>().TakeDamage(damageValue, hitDirection); // acess the health manager and take damage apply hit direction to the players knockback
        }

    } // end of trigger

    void DestroyProjectile()
    {

        Destroy(gameObject); // destroys the projectile

    } // end of DestroyProjectile


} // end of class
