using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TTstatus : MonoBehaviour
{
    // variables
    public static TTstatus instance; // allows other scripts to access this one

    public static bool T1Complete; // used to determine if the level has been completed or not
    public static bool T2Complete; // used to determine if the level has been completed or not
    public static bool T3Complete; // used to determine if the level has been completed or not
    public static bool T4Complete; // used to determine if the level has been completed or not
    public static bool T5Complete; // used to determine if the level has been completed or not
    public static bool T6Complete; // used to determine if the level has been completed or not
    public static bool T7Complete; // used to determine if the level has been completed or not
    public static bool T8Complete; // used to determine if the level has been completed or not
    public static bool T9Complete; // used to determine if the level has been completed or not
    public static bool T10Complete; // used to determine if the level has been completed or not

    public GameObject[] TTstars; // stores an array of star GO to be activated when the level is completed

    private void Awake()
    {
        instance = this; // ensures using THIS instance of the script
    }

    private void Start()
    {
        if(T1Complete == true) // if the player has completed level 1 TT
        {
            TTstars[0].SetActive(true); // activate the star
        }
        if(T2Complete == true)
        {
            TTstars[1].SetActive(true);
        }
        if (T3Complete == true)
        {
            TTstars[2].SetActive(true);
        }
        if (T4Complete == true)
        {
            TTstars[3].SetActive(true);
        }
        if (T5Complete == true)
        {
            TTstars[4].SetActive(true);
        }
        if (T6Complete == true)
        {
            TTstars[5].SetActive(true);
        }
        if (T7Complete == true)
        {
            TTstars[6].SetActive(true);
        }
        if (T8Complete == true)
        {
            TTstars[7].SetActive(true);
        }
        if (T9Complete == true)
        {
            TTstars[8].SetActive(true);
        }
        if (T10Complete == true)
        {
            TTstars[9].SetActive(true);
        }



    } // end of start


}
