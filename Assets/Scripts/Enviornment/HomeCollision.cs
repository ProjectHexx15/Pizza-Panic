using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeCollision : MonoBehaviour
{
    // variables
    private AudioManager audioManger; // used to add sound to the player
    public MenuManager menuManager;

    private void Awake()
    {
        audioManger = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>(); // finds the audio manager and stores its AM component
    } // end of awake

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            if(SceneManager.GetActiveScene().name == "Tutorial")
            {
                StickerManager.tutorialComplete = true; // the player has completed the tutorial
                PlayerPrefs.SetInt("completedTutorial", StickerManager.tutorialComplete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
                
            }
            else if(SceneManager.GetActiveScene().name == "T1") // if the player completed T1
            {
                TTstatus.T1Complete = true;
                PlayerPrefs.SetInt("completedTT1", TTstatus.T1Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T2") // if the player completed T1
            {
                TTstatus.T2Complete = true;
                PlayerPrefs.SetInt("completedTT2", TTstatus.T2Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T3") // if the player completed T1
            {
                TTstatus.T3Complete = true;
                PlayerPrefs.SetInt("completedTT3", TTstatus.T3Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T4") // if the player completed T1
            {
                TTstatus.T4Complete = true;
                PlayerPrefs.SetInt("completedTT4", TTstatus.T4Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T5") // if the player completed T1
            {
                TTstatus.T5Complete = true;
                PlayerPrefs.SetInt("completedTT5", TTstatus.T5Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T6") // if the player completed T1
            {
                TTstatus.T6Complete = true;
                PlayerPrefs.SetInt("completedTT6", TTstatus.T6Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T7") // if the player completed T1
            {
                TTstatus.T7Complete = true;
                PlayerPrefs.SetInt("completedTT7", TTstatus.T7Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T8") // if the player completed T1
            {
                TTstatus.T8Complete = true;
                PlayerPrefs.SetInt("completedTT8", TTstatus.T8Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T9") // if the player completed T1
            {
                TTstatus.T9Complete = true;
                PlayerPrefs.SetInt("completedTT9", TTstatus.T9Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }
            else if (SceneManager.GetActiveScene().name == "T10") // if the player completed T1
            {
                TTstatus.T10Complete = true;
                PlayerPrefs.SetInt("completedTT10", TTstatus.T10Complete ? 1 : 0);
                MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
            }

            MenuManager.instance.Victory(); // loads the victory screen when the player touches the home
        }
    } // end of trigger detection

 } // end of class
