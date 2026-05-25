using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickerManager : MonoBehaviour
{
    public static StickerManager instance; // creates a public instance of this script

    // CAMPAIGN
    // used to determine if the player has collected the sticker or not - value unchanging globably
    public static bool isSticker1Collected;
    public static bool isSticker2Collected; 
    public static bool isSticker3Collected; 
    public static bool isSticker4Collected; 
    public static bool isSticker5Collected; 
    public static bool isSticker6Collected;
    public static bool isSticker7Collected;
    public static bool isSticker8Collected;
    public static bool isSticker9Collected;
    public static bool isSticker10Collected;
    public static bool isSticker11Collected;
    public static bool isSticker12Collected;
    public static bool isSticker13Collected;    
    public static bool isSticker14Collected;    
    public static bool isSticker15Collected;
    public static bool isSticker16Collected;
    public static bool isSticker17Collected;
    public static bool isSticker18Collected;
    public static bool isSticker19Collected;
    public static bool isSticker20Collected;
    public static bool isSticker21Collected;
    public static bool isSticker22Collected;
    public static bool isSticker23Collected;
    public static bool isSticker24Collected;
    public static bool isSticker25Collected;
    public static bool isSticker26Collected;
    public static bool isSticker27Collected;
    public static bool isSticker28Collected;
    public static bool isSticker29Collected;
    public static bool isSticker30Collected;
    public static bool isSticker31Collected;


    // TUTORIAL
    public static bool tutorialComplete; // used to determine if the tutorial sticker should be awarded

    private void Awake()
    {
        instance = this; // allows other scripts to access this one
    }

}
