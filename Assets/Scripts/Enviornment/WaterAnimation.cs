using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterAnimation : MonoBehaviour
{
    // variables
    public Material[] watermats; // stores the water materials
    public float changeSpeed; // stores how fast the change between materials will be
    public Renderer rend; // stores the waters renderer component

    private void Start()
    {
        rend = GetComponent<Renderer>(); // gets the renderer component from the water
        rend.material = watermats[0]; // change the material to the first in the array at start of the game so all water is in sync
        StartCoroutine(waterAnim()); // calls the waterAnim coroutine
    }

    private IEnumerator waterAnim()
    {
        while (true)
        {
            rend.material = watermats[0]; // change the material to the first in the array
            yield return new WaitForSeconds(changeSpeed); // wait for the specified amount of time
            rend.material = watermats[1]; // change the material to the second in the array
            yield return new WaitForSeconds(changeSpeed); // wait for the specified amount of time
        }

    } // end of waterAnim


} // end of class
