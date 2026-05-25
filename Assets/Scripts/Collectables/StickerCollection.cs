using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerCollection : MonoBehaviour
{
    // variables
    public GameObject[] StickerArray; // stores the stickers in the collection menu

    private void Awake()
    {
        StickerManager.tutorialComplete = PlayerPrefs.GetInt("completedTutorial") == 1; // gets the value and updates the player collection
        StickerManager.isSticker1Collected = PlayerPrefs.GetInt("Sticker1Collected") == 1; 
        StickerManager.isSticker3Collected = PlayerPrefs.GetInt("Sticker3Collected") == 1; 
        StickerManager.isSticker4Collected = PlayerPrefs.GetInt("Sticker4Collected") == 1; 
        StickerManager.isSticker5Collected = PlayerPrefs.GetInt("Sticker5Collected") == 1; 
        StickerManager.isSticker6Collected = PlayerPrefs.GetInt("Sticker6Collected") == 1; 

    } // end of awake

    private void Start()
    {
        // activate campaign stickers if it has been found
        if (StickerManager.tutorialComplete == true) 
        {
            StickerArray[0].SetActive(true); 
        }

        // campaign
        if (StickerManager.isSticker1Collected == true) 
        {
            StickerArray[1].SetActive(true); 
        }
        if (StickerManager.isSticker2Collected == true) 
        {
            StickerArray[2].SetActive(true); 
        }
        if (StickerManager.isSticker3Collected == true) 
        {
            StickerArray[3].SetActive(true); 
        }
        if(StickerManager.isSticker4Collected == true)
        {
            StickerArray[4].SetActive(true);
        }
        if (StickerManager.isSticker5Collected == true)
        {
            StickerArray[5].SetActive(true);
        }
        if (StickerManager.isSticker6Collected == true)
        {
            StickerArray[6].SetActive(true);
        }
        if (StickerManager.isSticker7Collected == true)
        {
            StickerArray[7].SetActive(true);
        }
        if (StickerManager.isSticker8Collected == true)
        {
            StickerArray[8].SetActive(true);
        }
        if (StickerManager.isSticker9Collected == true)
        {
            StickerArray[9].SetActive(true);
        }
        if (StickerManager.isSticker10Collected == true)
        {
            StickerArray[10].SetActive(true);
        }
        if (StickerManager.isSticker11Collected == true)
        {
            StickerArray[11].SetActive(true);
        }
        if (StickerManager.isSticker12Collected == true)
        {
            StickerArray[12].SetActive(true);
        }
        if (StickerManager.isSticker13Collected == true)
        {
            StickerArray[13].SetActive(true);
        }
        if (StickerManager.isSticker14Collected == true)
        {
            StickerArray[14].SetActive(true);
        }
        if (StickerManager.isSticker15Collected == true)
        {
            StickerArray[15].SetActive(true);
        }
        if (StickerManager.isSticker16Collected == true)
        {
            StickerArray[16].SetActive(true);
        }
        if (StickerManager.isSticker17Collected == true)
        {
            StickerArray[17].SetActive(true);
        }
        if (StickerManager.isSticker18Collected == true)
        {
            StickerArray[18].SetActive(true);
        }
        if (StickerManager.isSticker19Collected == true)
        {
            StickerArray[19].SetActive(true);
        }
        if (StickerManager.isSticker20Collected == true)
        {
            StickerArray[20].SetActive(true);
        }
        if (StickerManager.isSticker21Collected == true)
        {
            StickerArray[21].SetActive(true);
        }
        if (StickerManager.isSticker22Collected == true)
        {
            StickerArray[22].SetActive(true);
        }
        if (StickerManager.isSticker23Collected == true)
        {
            StickerArray[23].SetActive(true);
        }
        if (StickerManager.isSticker24Collected == true)
        {
            StickerArray[24].SetActive(true);
        }
        if (StickerManager.isSticker25Collected == true)
        {
            StickerArray[25].SetActive(true);
        }
        if (StickerManager.isSticker26Collected == true)
        {
            StickerArray[26].SetActive(true);
        }
        if (StickerManager.isSticker27Collected == true)
        {
            StickerArray[27].SetActive(true);
        }
        if (StickerManager.isSticker28Collected == true)
        {
            StickerArray[28].SetActive(true);
        }
        if (StickerManager.isSticker29Collected == true)
        {
            StickerArray[29].SetActive(true);
        }
        if (StickerManager.isSticker30Collected == true)
        {
            StickerArray[30].SetActive(true);
        }
        // TIME TRIAL
        // activcate time trial stickers if the level was completed
        if (TTstatus.T1Complete == true)
        {
            StickerArray[31].SetActive(true);
        }
        if (TTstatus.T2Complete == true)
        {
            StickerArray[32].SetActive(true);
        }
        if (TTstatus.T3Complete == true)
        {
            StickerArray[33].SetActive(true);
        }
        if (TTstatus.T4Complete == true)
        {
            StickerArray[34].SetActive(true);
        }
        if (TTstatus.T5Complete == true)
        {
            StickerArray[35].SetActive(true);
        }
        if (TTstatus.T6Complete == true)
        {
            StickerArray[36].SetActive(true);
        }
        if (TTstatus.T7Complete == true)
        {
            StickerArray[37].SetActive(true);
        }
        if (TTstatus.T8Complete == true)
        {
            StickerArray[38].SetActive(true);
        }
        if (TTstatus.T9Complete == true)
        {
            StickerArray[39].SetActive(true);
        }
        if (TTstatus.T10Complete == true)
        {
            StickerArray[40].SetActive(true);
        }

    } // end of start


} // end of class
