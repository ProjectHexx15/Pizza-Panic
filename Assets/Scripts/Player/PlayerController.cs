using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Variables and References
    // movement
    public float playerSpeed; // stores how fast the player can currently move
    public float playerMaxSpeed; // stores the players regular movement speed
    public Rigidbody playerRbody; // allows us to acess the RigidBody component attached to the player object
    private float verticalInput; // used to store the vertical inputs recieved
    private float horizontalInput; // used to store the horizontal inputs recieved

    // jump
    public float jumpForce; // stores how much force will be applied to the players velocity when they jump
    public int jumpCount; // stores how many times the player can jump
    public int grav; // this force is constantly applied to the player to prevent them from flying
    public bool isGrounded; // will be used to determine if the player is touching the ground or not

    // sprint
    public float sprintSpeed; // stores how fast the player moves when sprinting
    public float maxSprintTimer; // stores the sprint timers max amount - used to reset the timer
    public float sprintTimer; // stores the current timer amount

    // animations
    public Animator anim; // stores the players animator component
    public bool walking; // used to determine if the player is walking or not
    public bool sprinting; // used to determine if the player is sprinting or not
    public int sprintAnimSpeed; // stores how fast the sprint anaimation should be when player is sprinting

    // knockback
    private float knockbackForce = 3; // stores the amount of force that will be applied to the player when they are hurt
    public float knockbackTime; // stores how long the player should be knocked back for
    private float knockbackCounter; // used to determine if the player should still be knocked back or not

    public static PlayerController instance; // allows other scripts to reference this one
    private AudioManager audioManger; // used to add sound to the player

    // enemy
    public int timeToKill; // how long before enemy is killed
    public ParticleSystem ouchEffect; // emmits this effect when enemy is killed

  

    private void Awake()
    {
        instance = this;
        audioManger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); // finds the audio manager and stores its AM component


    } // end of awake


    // Start is called before the first frame update
    void Start()
    {
        playerRbody = GetComponent<Rigidbody>(); // when the game is started - set this variable to the rigidbody component  attached to the object this script is on - the player
        jumpCount = 2; // sets the players jump count to 2 at the start of the game
        playerMaxSpeed = playerSpeed; // resets the player speed when the game is started
        sprintTimer = maxSprintTimer; // restes the timer when the game is started

        anim = GetComponent<Animator>(); // gets the animator component from the player and stores it
    } // end of start

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");  // stores the Vertical inputs in this variable
        horizontalInput = Input.GetAxis("Horizontal"); // stores the horizontal inputs in this variable
        walking = false; //player is not walking anymore


        if(knockbackCounter <= 0) // if the knockback counter has ranout
        {
            // player can move as normal

            playerMove(); // calls the player move function
            playerJump(); // calls the jump function
            updateAnimation(); // call the updateAnimation function
            refillStamina(); // calls the refil stamina function
        }
        else // if the knockback timer has NOT ranout
        {
            knockbackCounter -= Time.deltaTime; // derement the counter
        }

    } // end of update

    private void playerMove()
    {
        Vector3 MoveVector = (-transform.forward * verticalInput) * playerSpeed + (-transform.right * horizontalInput) * playerSpeed; 
        // creates a new vector 3 using transform.forward and the input recieved from the vertical inputs
        playerRbody.velocity = new Vector3(MoveVector.x, playerRbody.velocity.y, MoveVector.z);
        // applies this vector to the rb component of the player        

        // LEFT SHIFT
        if (Input.GetKey(KeyCode.LeftShift) && sprintTimer > 0) // if the player presses the left shift button
        {
            playerSpeed = sprintSpeed; // set the players speed to the sprint speed
            sprinting = true; // the player IS sprinting
            sprintTimer -= Time.deltaTime; // decrement the sprint timer
            
          
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift)) // when the player releases the sprint button
        {
            refillStamina(); // call the reill stamina function
            sprinting = false; // the player is NOT sprinting
        }

        if(sprintTimer <= 0) // if the sprint timer has depleted
        {
            playerSpeed = playerMaxSpeed; // set the players speed back to normal
            sprinting = false; // the player is NOT sprinting
        }

        if(horizontalInput == 1) // if recieving horizontal input (A)
        {
            walking = true; // the player IS wakling
        }
        else if(horizontalInput == -1) // if recieving horizontal input (D)
        {
            walking = true; // the player IS wakling
        }
        else if(verticalInput ==  1) // if recieving vertical input (W)
        {
            walking = true; // the player IS walking
        }
        else if(verticalInput == -1) // if recieving vertical input (S)
        {
            walking = true; // the player IS walking
        } // end else
      
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            MenuManager.instance.Pause(); // pauses the game when escape is pressed
        }

    } // end of player move


    private void playerJump()
    {
        if (Input.GetButtonDown("Jump") & jumpCount > 0) // if the player presses the jump button - spacebar
        {
            playerRbody.velocity = new Vector3(playerRbody.velocity.x, jumpForce, playerRbody.velocity.z);
            audioManger.PlaySFX(audioManger.boing); // plays the boing sound when player jumps
            jumpCount--; // jump counter decrements
            isGrounded = false; // player is NOT touching ground
                                // applies the jumpForce to the players velocity on the Y-Axis - X and Z are not affected
            anim.SetTrigger("isJumping"); // triggers the jumping animation for the player

        }
    
    } // end of player jump

    private void updateAnimation()
    {
        if(walking) // if the player IS walking
        {
            anim.speed = 1;
            anim.SetBool("isWalking", true); // set the walk animation parameter to true
        }
        else if(!walking) // if is NOT walking
        {
            anim.SetBool("isWalking", false); // set the wallk animation parameter to false
        }

        if(sprinting) // if the player is sprinting
        {
            anim.speed = 2; // double the animaiton speed to make them walk faster
        }
        else if(!sprinting) // if the player is not sprinting
        {
            anim.speed = 1; // set the speed back to 1
        }
    } // end of updateAnimation

    private void refillStamina()
    {
        // LEFT SHIFT
        if(!Input.GetKey(KeyCode.LeftShift)) // if the player is NOT holding shift
        {
            sprintTimer += Time.deltaTime; // increment the sprint timer
            playerSpeed = playerMaxSpeed; // change the players speed back to normal

            if(sprintTimer > maxSprintTimer) // if the sprint timer is more than the max
            {
                sprintTimer = maxSprintTimer; // reset the amount back to max
            }
        } // end if   
    } // end of refill stamina

    private void OnCollisionEnter(Collision collision)
    {
        // if the player collides with the ground
        if (collision.collider.tag == "Ground")
        {
            jumpCount = 2; 
            isGrounded = true;
            // reset the jump count when the player touches the ground
            // the player IS touching ground
        }
        else if(collision.collider.tag == "Enemy") // if the player jumps on the enemies head
        {
           Instantiate(ouchEffect, collision.transform.position, collision.transform.rotation); // instantiates the effect at the enemies position 
            audioManger.PlaySFX(audioManger.playerDeath); // plays this sound when enemy gets STOMPED
           Destroy(collision.gameObject, timeToKill); // destory the enemy after a second has passed

           FindObjectOfType<GameManager>().AddCoin(20); // add fifteen points to the players coin count for killing enemy
        }
        else if(collision.collider.tag == "Water") // if the player touches the water
        {
            FindObjectOfType<HealthManager>().currentHealth = 0;
            HealthManager.instance.invincibilityCounter = 0; // no invincibility if player collides with the water
        }



    } // end of collision detection

    public void Knockback(Vector3 direction) // uses this value to apply knockback to the player
    {
        knockbackCounter = knockbackTime; // the knockback timer is full - resets the timer
        playerRbody.velocity = direction * knockbackForce; // applies knockback force to the player
        anim.SetTrigger("isHurt"); // triggers the hurt animation

    } // end of knockback

    public void launchPlayer(int force)
    {
        playerRbody.velocity = new Vector3(playerRbody.velocity.x, force, playerRbody.velocity.z); // takes in launch force value to push player into the air
    } // end of launchPlayer

} // end of class
