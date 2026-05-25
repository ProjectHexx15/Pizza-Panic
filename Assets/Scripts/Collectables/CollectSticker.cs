using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSticker : MonoBehaviour
{
    // variables
    private AudioManager audioManger; // used to add sound to the player
    private void Awake()
    {
        audioManger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); // finds the audio manager and stores its AM component
    } // end of awake

    private void OnTriggerEnter(Collider other)
    { 

        if(this.gameObject.tag == "Sticker1"  && other.tag == "Player") // if the player colllides with sticker 1 specifically
        {
            StickerManager.isSticker1Collected = true; // the player has collected the sticker
            PlayerPrefs.SetInt("Sticker1Collected", StickerManager.isSticker1Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker2" && other.tag == "Player") // if the player colllides with sticker 2 specifically
        {
            StickerManager.isSticker2Collected = true; // the player has collected the sticker
            PlayerPrefs.SetInt("Sticker2Collected", StickerManager.isSticker2Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker3" && other.tag == "Player") // if the player colllides with sticker 2 specifically
        {
            StickerManager.isSticker3Collected = true; // the player has collected the sticker
            PlayerPrefs.SetInt("Sticker3Collected", StickerManager.isSticker3Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker4" && other.tag == "Player")
        {
            StickerManager.isSticker4Collected = true;
            PlayerPrefs.SetInt("Sticker4Collected", StickerManager.isSticker4Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker4" && other.tag == "Player")
        {
            StickerManager.isSticker4Collected = true;
            PlayerPrefs.SetInt("Sticker4Collected", StickerManager.isSticker4Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker5" && other.tag == "Player")
        {
            StickerManager.isSticker5Collected = true;
            PlayerPrefs.SetInt("Sticker5Collected", StickerManager.isSticker5Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker6" && other.tag == "Player")
        {
            StickerManager.isSticker6Collected = true;
            PlayerPrefs.SetInt("Sticker6Collected", StickerManager.isSticker6Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker7" && other.tag == "Player")
        {
            StickerManager.isSticker7Collected = true;
            PlayerPrefs.SetInt("Sticker7Collected", StickerManager.isSticker7Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker8" && other.tag == "Player")
        {
            StickerManager.isSticker8Collected = true;
            PlayerPrefs.SetInt("Sticker8Collected", StickerManager.isSticker8Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker9" && other.tag == "Player")
        {
            StickerManager.isSticker9Collected = true;
            PlayerPrefs.SetInt("Sticker9Collected", StickerManager.isSticker9Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker10" && other.tag == "Player")
        {
            StickerManager.isSticker10Collected = true;
            PlayerPrefs.SetInt("Sticker10Collected", StickerManager.isSticker10Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker11" && other.tag == "Player")
        {
            StickerManager.isSticker11Collected = true;
            PlayerPrefs.SetInt("Sticker11Collected", StickerManager.isSticker11Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker12" && other.tag == "Player")
        {
            StickerManager.isSticker12Collected = true;
            PlayerPrefs.SetInt("Sticker12Collected", StickerManager.isSticker12Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker13" && other.tag == "Player")
        {
            StickerManager.isSticker13Collected = true;
            PlayerPrefs.SetInt("Sticker13Collected", StickerManager.isSticker13Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker14" && other.tag == "Player")
        {
            StickerManager.isSticker14Collected = true;
            PlayerPrefs.SetInt("Sticker14Collected", StickerManager.isSticker14Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker15" && other.tag == "Player")
        {
            StickerManager.isSticker15Collected = true;
            PlayerPrefs.SetInt("Sticker15Collected", StickerManager.isSticker15Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker16" && other.tag == "Player")
        {
            StickerManager.isSticker16Collected = true;
            PlayerPrefs.SetInt("Sticker16Collected", StickerManager.isSticker16Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker17" && other.tag == "Player")
        {
            StickerManager.isSticker17Collected = true;
            PlayerPrefs.SetInt("Sticker17Collected", StickerManager.isSticker17Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker18" && other.tag == "Player")
        {
            StickerManager.isSticker18Collected = true;
            PlayerPrefs.SetInt("Sticker18Collected", StickerManager.isSticker18Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker19" && other.tag == "Player")
        {
            StickerManager.isSticker19Collected = true;
            PlayerPrefs.SetInt("Sticker19Collected", StickerManager.isSticker19Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker20" && other.tag == "Player")
        {
            StickerManager.isSticker20Collected = true;
            PlayerPrefs.SetInt("Sticker20Collected", StickerManager.isSticker20Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker21" && other.tag == "Player")
        {
            StickerManager.isSticker21Collected = true;
            PlayerPrefs.SetInt("Sticker21Collected", StickerManager.isSticker21Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker22" && other.tag == "Player")
        {
            StickerManager.isSticker22Collected = true;
            PlayerPrefs.SetInt("Sticker22Collected", StickerManager.isSticker22Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker23" && other.tag == "Player")
        {
            StickerManager.isSticker23Collected = true;
            PlayerPrefs.SetInt("Sticker23Collected", StickerManager.isSticker23Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker24" && other.tag == "Player")
        {
            StickerManager.isSticker24Collected = true;
            PlayerPrefs.SetInt("Sticker24Collected", StickerManager.isSticker24Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker25" && other.tag == "Player")
        {
            StickerManager.isSticker25Collected = true;
            PlayerPrefs.SetInt("Sticker25Collected", StickerManager.isSticker25Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker26" && other.tag == "Player")
        {
            StickerManager.isSticker26Collected = true;
            PlayerPrefs.SetInt("Sticker26Collected", StickerManager.isSticker26Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker27" && other.tag == "Player")
        {
            StickerManager.isSticker27Collected = true;
            PlayerPrefs.SetInt("Sticker27Collected", StickerManager.isSticker27Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker28" && other.tag == "Player")
        {
            StickerManager.isSticker28Collected = true;
            PlayerPrefs.SetInt("Sticker28Collected", StickerManager.isSticker28Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker29" && other.tag == "Player")
        {
            StickerManager.isSticker29Collected = true;
            PlayerPrefs.SetInt("Sticker29Collected", StickerManager.isSticker29Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker30" && other.tag == "Player")
        {
            StickerManager.isSticker30Collected = true;
            PlayerPrefs.SetInt("Sticker30Collected", StickerManager.isSticker30Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }
        if (this.gameObject.tag == "Sticker31" && other.tag == "Player")
        {
            StickerManager.isSticker31Collected = true;
            PlayerPrefs.SetInt("Sticker31Collected", StickerManager.isSticker31Collected ? 1 : 0);
            audioManger.PlaySFX(audioManger.collectSticker);
        }



    } // end of trigger detection
}
