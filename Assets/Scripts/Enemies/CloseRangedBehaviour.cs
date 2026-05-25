using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Rendering;

public class CloseRangedBehaviour : MonoBehaviour
{
    // variables
    public NavMeshAgent agent; // used to store the enemies nav mesh agent
    public Transform player; // used to store the transform position of the player
    public GameObject playerObj; // used to knockback the player when they are hit by enemy
    public LayerMask whatsIsGround, whatIsPlayer; // used to detect the ground and player layers

    // Patrolling
    public Vector3 walkPoint; // stores the position the enemy will patrol around
    bool walkPointSet; // used to determine if the wallk point has been set or not
    public float walkPointRange; // used to store the range the enemy can walk from the walK point

    // Attacking
    public float timeBetweenAttacks; // stores the amount of time inbetween the attacks of the enemy
    bool alreadyAttacked; // used to determine if the player has attacked or not
    public int damageValue; // how much damage the attacker does

    // States
    public float sightRange, attackRange; // stores the enemies sight range and attack range values
    public bool playerInSightRange, playerInAttackRange; // used to determine if the player is in the enemies sight range + attack range

    // animation
    public Animator animator; // stores this enemies animator component

    private void Awake()
    {
        player = GameObject.Find("Liam").transform; // finds the transform position of the player and stores it in this variable
        agent = GetComponent<NavMeshAgent>(); // assigns the enemies nav mesh component to this variable

    } // end of awake

    private void Update()
    {
       // check if the player is within sight and attack range
       playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer); // takes in the position of the player, the sight on the enemy and the player layer to detect player within range
       playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer); // takes in the position of the player, the attack range of enemy and the player layer to detect player within range

        if (!playerInSightRange && !playerInAttackRange) Patrolling(); // if the player is not within sight range and not within attack range - then the enemy should patrol

        if (playerInSightRange && !playerInAttackRange) Chasing(); // if the player is within sight range and not within attack range - the enemy should chase player

        if(playerInSightRange && playerInAttackRange) Attacking(); // if the player is within sight range and within attack range - the enemy should attack the player

    } // end of update

    private void Patrolling()
    {
         
        if(walkPointSet) // if the walk point has been set
        {
            agent.SetDestination(walkPoint); // if the walkpoint is set, navigate the enemy to it
            animator.SetBool("isWalking", true); // plays walking animation
            
        }
        else if (!walkPointSet) // if the walk point is not set
        {
            SearchWalkPoint(); // if there is no walk point set then search for the next point
            animator.SetBool("isWalking", false); // stops playing walking animation
        }

        Vector3 distanceToWalkPoint = transform.position - walkPoint; // calculates the distance from the enemy to to the walkpoint

        // if the enemy has reached the walk point
        if(distanceToWalkPoint.magnitude < 1f)
        {
            walkPointSet = false; // enemy has reached walk point and needs to look for a new one
        }

    } // end of patrolling

    private void SearchWalkPoint()
    {
        // calculate a random point in the walkpoint range
        float randomZ = Random.Range(-walkPointRange, walkPointRange); // returns a random value depending on players walkpoint range - in the Z axis
        float randomX = Random.Range(-walkPointRange,walkPointRange); // returns a random value depending on the players walkpoint range - in the x axis

        

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ); // uses the calculated random values to create a walk point for the enemy to go to

        if(Physics.Raycast(walkPoint, -transform.up, 2f, whatsIsGround)) // if the walkpoint is touching ground
        {
            walkPointSet = true; // this walk point can be used
        }


    } // end of search walk point

    private void Attacking()
    {
        // stops the player from moving
        agent.SetDestination(transform.position);

        

        if(!alreadyAttacked) // if the enemy hasnt attacked the player
        {
            animator.SetTrigger("isAttacking"); // plays the attacking animation
            Vector3 hitDirection = playerObj.transform.position - transform.position; // gets the opposite of the players direction so can apply the knockback force
            hitDirection = hitDirection.normalized; // restricts the hittdirection to be in a straight line distance - ensures knockback is consistant

            FindObjectOfType<HealthManager>().TakeDamage(damageValue, hitDirection); // acess the health manager and take damage apply hit direction to the players knockback

            alreadyAttacked = true; // the enemy has now attacked the player
            Invoke(nameof(ResetAttack), timeBetweenAttacks); // invokes the reset attack function using the timebetween attacks as a delay
        }

    } // end of attacking

    private void ResetAttack()
    {
        alreadyAttacked = false; // resets the enemies attack
    } // end of resetattack

    private void Chasing()
    {
        agent.SetDestination(player.position); // the enemy will chase the player
        animator.SetBool("isWalking", true); // plays walking animation
    } // end of chasing


} // end of class
