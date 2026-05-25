using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // variables and references
    public Transform target; //this stores the transform position that will be used to space the camera from the player
    public Vector3 offset; // stores how far away the player camera should be

    private float rotateSpeed = 3; // this stores how fast the camera will rotate

    public bool useOffsetValue; // determines if the camera offset is used or not

    public Transform pivot; // used to store the transform position of the pivot point

    public static bool invertY; // will be used in the settings to invert the camera movement

    

    // Start is called before the first frame update
    void Start()
    {
        // sets the offset value to the position of the target - player - minus the transform position of the camera
        // this calculates the offset position

        // if not using the offset value
        if(!useOffsetValue)
        {
            offset = target.position - transform.position;

        }

        offset = target.position - transform.position; 

        pivot.transform.position = target.transform.position; // sets the pivot to the position of the player
        pivot.transform.parent = target.transform; // sets the pivot as a child of the player so that it moves with it

        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen when the game is started
        
    } // end of start

    // Update is called once per frame
    void Update()
    {
        // get the X position of the mouse and rotate the target using the position
        float horizontal = Input.GetAxis("Mouse X") * rotateSpeed;
        target.Rotate(0, horizontal, 0);

        // get the Y position of the mouse and rotate the pivot using the position
        float vertical = Input.GetAxis("Mouse Y") * rotateSpeed;
        

        if(!invertY)
        {
            pivot.Rotate(-vertical, 0, 0);
        }
        else
        {
            pivot.Rotate(vertical, 0, 0);
        }

        // limit the up and down rotation of the pivot
        if (pivot.rotation.eulerAngles.x > 20f && pivot.rotation.eulerAngles.x < 180f) // if the rotaiton on the x axis is greater than 20 and less than 180
        {
            pivot.rotation = Quaternion.Euler(20f, 0, 0); // maintains the rotation - prevents player from looking down further
        }
        if(pivot.rotation.eulerAngles.x > 180f && pivot.rotation.eulerAngles.x < 315f) // if the rotation on the x axis is greater than 180 and less than 315
        {
            pivot.rotation = Quaternion.Euler(315f, 0, 0); // maintains the rotation - prevents player from looking up further
        }

        // move the camera based on the current rotation of the target and the original offset
        float desiredYAngle = target.eulerAngles.y; // Y rotation
        float desiredXAngle = pivot.eulerAngles.x; // X roation
        // euler is the rotation in the worldspace 

        Quaternion rotation = Quaternion.Euler(desiredXAngle, desiredYAngle, 0);
        // creates a new rotation 

        transform.position = target.position - (rotation * offset);
        // updates cameras position using the target and the new rotation created,
     



        transform.LookAt(target); // this will make the camera rotate its position, so that it is looking at the player
    } // end of update

} // end of class
