using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDisplay : MonoBehaviour
{
    // variables
    public GameObject[] stars1Cam; // stores the star gameobjects for each level
    public GameObject[] stars2Cam; 
    public GameObject[] stars3Cam;
    public GameObject[] stars4Cam;
    public GameObject[] stars5Cam;
    public GameObject[] stars6Cam;
    public GameObject[] stars7Cam;
    public GameObject[] stars8Cam;
    public GameObject[] stars9Cam;
    public GameObject[] stars10Cam;


    public float starsCam1; // stores the players percentage value
    public float starsCam2; 
    public float starsCam3;
    public float starsCam4;
    public float starsCam5;
    public float starsCam6;
    public float starsCam7;
    public float starsCam8;
    public float starsCam9;
    public float starsCam10;

    private void Awake()
    {
        starsCam1 = PlayerPrefs.GetFloat("percentageCampaign1", 0); // stores the percentages calculated at the end of each level
        starsCam2 = PlayerPrefs.GetFloat("percentageCampaign2", 0);
        starsCam3 = PlayerPrefs.GetFloat("percentageCampaign3", 0);
        starsCam4 = PlayerPrefs.GetFloat("percentageCampaign4", 0);
        starsCam5 = PlayerPrefs.GetFloat("percentageCampaign5", 0);
        starsCam6 = PlayerPrefs.GetFloat("percentageCampaign6", 0);
        starsCam7 = PlayerPrefs.GetFloat("percentageCampaign7", 0);
        starsCam8 = PlayerPrefs.GetFloat("percentageCampaign8", 0);
        starsCam9 = PlayerPrefs.GetFloat("percentageCampaign9", 0);
        starsCam10 = PlayerPrefs.GetFloat("percentageCampaign10", 0);
    } // end of awake

    private void Start()
    {
        // LEVEL 1 CAMPAIGN
        if(starsCam1 < 33) // if the player sucks soosososoosos bad
        {
            stars1Cam[0].SetActive(false); // deactivates the first star
            stars1Cam[1].SetActive(false); // deactivates the second star
            stars1Cam[2].SetActive(false); // deactivates the third star
        }
        else if(starsCam1 >= 33f && starsCam1 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars1Cam[0].SetActive(true); // activates the first star
        }
        else if(starsCam1 >= 66f && starsCam1 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars1Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars1Cam[2].SetActive(true); // activates the third star
        }




        // level 2
        if (starsCam2 < 33) // if the player sucks soosososoosos bad
        {
            stars2Cam[0].SetActive(false); // deactivates the first star
            stars2Cam[1].SetActive(false); // deactivates the second star
            stars2Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam2 >= 33f && starsCam2 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars2Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam2 >= 66f && starsCam2 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars2Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars2Cam[2].SetActive(true); // activates the third star
        }




        // level 3
        if (starsCam3 < 33) // if the player sucks soosososoosos bad
        {
            stars3Cam[0].SetActive(false); // deactivates the first star
            stars3Cam[1].SetActive(false); // deactivates the second star
            stars3Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam3 >= 33f && starsCam3 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars3Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam3 >= 66f && starsCam3 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars3Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars3Cam[2].SetActive(true); // activates the third star
        }



        // level 4
        if (starsCam4 < 33) // if the player sucks soosososoosos bad
        {
            stars4Cam[0].SetActive(false); // deactivates the first star
            stars4Cam[1].SetActive(false); // deactivates the second star
            stars4Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam4 >= 33f && starsCam4 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars4Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam4 >= 66f && starsCam4 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars4Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars4Cam[2].SetActive(true); // activates the third star
        }




        // level 5
        if (starsCam5 < 33) // if the player sucks soosososoosos bad
        {
            stars5Cam[0].SetActive(false); // deactivates the first star
            stars5Cam[1].SetActive(false); // deactivates the second star
            stars5Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam5 >= 33f && starsCam5 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars5Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam5 >= 66f && starsCam5 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars5Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars5Cam[2].SetActive(true); // activates the third star
        }




        // level 6
        if (starsCam6 < 33) // if the player sucks soosososoosos bad
        {
            stars6Cam[0].SetActive(false); // deactivates the first star
            stars6Cam[1].SetActive(false); // deactivates the second star
            stars6Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam6 >= 33f && starsCam6 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars6Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam6 >= 66f && starsCam6 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars6Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars6Cam[2].SetActive(true); // activates the third star
        }




        // level 7
        if (starsCam7 < 33) // if the player sucks soosososoosos bad
        {
            stars7Cam[0].SetActive(false); // deactivates the first star
            stars7Cam[1].SetActive(false); // deactivates the second star
            stars7Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam7 >= 33f && starsCam7 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars7Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam7 >= 66f && starsCam7 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars7Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars7Cam[2].SetActive(true); // activates the third star
        }




        // level 8
        if (starsCam8 < 33) // if the player sucks soosososoosos bad
        {
            stars8Cam[0].SetActive(false); // deactivates the first star
            stars8Cam[1].SetActive(false); // deactivates the second star
            stars8Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam8 >= 33f && starsCam8 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars8Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam8 >= 66f && starsCam8 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars8Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars8Cam[2].SetActive(true); // activates the third star
        }




        // level 9
        if (starsCam9 < 33) // if the player sucks soosososoosos bad
        {
            stars9Cam[0].SetActive(false); // deactivates the first star
            stars9Cam[1].SetActive(false); // deactivates the second star
            stars9Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam9 >= 33f && starsCam9 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars9Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam9 >= 66f && starsCam9 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars9Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars9Cam[2].SetActive(true); // activates the third star
        }

        // level 10
        if (starsCam10 < 33) // if the player sucks soosososoosos bad
        {
            stars10Cam[0].SetActive(false); // deactivates the first star
            stars10Cam[1].SetActive(false); // deactivates the second star
            stars10Cam[2].SetActive(false); // deactivates the third star
        }
        else if (starsCam10 >= 33f && starsCam10 < 66f) // if the percentage is within the 1 star value
        {
            // ONE STAR
            stars10Cam[0].SetActive(true); // activates the first star
        }
        else if (starsCam10 >= 66f && starsCam10 < 70f) // if the percentage is within the 2 star value
        {
            // TWO STAR
            stars10Cam[1].SetActive(true); // activates the second star
        }
        else // higher than or = 70 - 3 star percentage
        {
            // THREE STAR
            stars10Cam[2].SetActive(true); // activates the third star
        }



    } // end of star

} // end of class
