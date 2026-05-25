using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovingObject : MonoBehaviour
{
    // variables
    public GameObject pointA; // stores the pointA game object
    public GameObject pointB; // stores the pointB game object
    public float moveSpeed; // stores how fast the object will move
    public float delay; // stores how long the delay between traveling to the next point should be
    public GameObject movingObject; // this stores the object that will be moving - platform or obstacle

    private Vector3 targetPos; // stores the current position of the target point

    // Start is called before the first frame update
    void Start()
    {
        movingObject.transform.position = pointA.transform.position; // at the start of the game, the platform begins at point A
        targetPos = pointB.transform.position; // the target position of the moving object is set to point B
        StartCoroutine(MovePlatform()); // begins the move platform coroutine at the start of the match
      
    } // end of start

    IEnumerator MovePlatform()
    {
        while (true) // infinite while loop
        {
            while((targetPos - movingObject.transform.position).sqrMagnitude > 0.01f) // while the object is not at the target position
            {
                movingObject.transform.position = Vector3.MoveTowards(movingObject.transform.position, targetPos, moveSpeed * Time.deltaTime);
                // move the object towards the position of the target position at the movement speed
                yield return null; // pauses the co routine until the next frame

            }

            targetPos = targetPos == pointA.transform.position ? pointB.transform.position : pointA.transform.position;
            // once the moving object reaches the target, change the target to the point not currently targeted
            yield return new WaitForSeconds(delay); // delays for the amount of time before looping again

        }

    } // end of MovePlatform

 
} // end of class
