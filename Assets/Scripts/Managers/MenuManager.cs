using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Variables
    public GameObject gameOverPannel; // stores the game over pannel
    public GameObject victoryPannel; // stores the victory pannel
    public GameObject pausePannel; // stores the pause pannel 
    public GameObject godmodePannel; // stores the godmode pannel
    public static MenuManager instance; // creates a public instance of this script
    public StarManager starManager; // allows access to the star  manager script

    // help and tips pages
    public GameObject panel1; // stores the first pannel
    public GameObject panel2; // stores the second pannel
    public GameObject panel3; // stores the third pannel
    public GameObject panel4; // stores the fourth pannel

    // collectable pages
    public GameObject notebook1; // stores the first notebook page
    public GameObject notebook2; // stores the second notebook page
    public GameObject notebook3; // stores the third notebook page

    private void Awake()
    {
        instance = this; // allows other scripts to access this one
    } // end of awake

    public enum Scene
    {
        MainMenu,
        ModeSelect,
        CampaignSelect,
        TimeTrialSelect,
        Settings,
        Collectables,
        HowToPlay,
        Tutorial,
        C1,
        C2,
        C3,
        C4,
        C5,
        C6,
        C7,
        C8,
        C9,
        C10,
        T1,
        T2,
        T3,
        T4,
        T5,
        T6,
        T7,
        T8,
        T9,
        T10
    
    } // stores the scenes in a constant list 

    public static void Load(Scene scene)
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(scene.ToString()); // loads the entered scene

    } // end of load

    public void MainMenu()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.MainMenu.ToString()); // loads the main menu
    }

    public void ModeSelect()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.ModeSelect.ToString()); // loads the mode select scene
    } // end of mode select

    public void CampaignSelect()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.CampaignSelect.ToString()); // loads the campaign select
    } // end of campaign select

    public void TimeTrialSelect()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.TimeTrialSelect.ToString()); // loads the time trial select
    } // end of time trial select

    public void Settings()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.Settings.ToString()); // loads the settings menu
    } // end of settings

    public void Collectable()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.Collectables.ToString()); // loads the collectables menu
    } // end of collectable

    public void HowToPlay()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        SceneManager.LoadScene(Scene.HowToPlay.ToString()); // loads the how to play menu
    } // end of how to play

    public void Tutorial()
    {
        SceneManager.LoadScene(Scene.Tutorial.ToString()); // loads the tutorial level
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of tutorial

    public void C1()
    {
        SceneManager.LoadScene(Scene.C1.ToString()); // loads level 1 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c1

    public void C2()
    {
        SceneManager.LoadScene(Scene.C2.ToString()); // loads level 2 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c2

    public void C3()
    {
        SceneManager.LoadScene(Scene.C3.ToString()); // loads level 3 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c3

    public void C4()
    {
        SceneManager.LoadScene(Scene.C4.ToString()); // loads level 4 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c4

    public void C5()
    {
        SceneManager.LoadScene(Scene.C5.ToString()); // loads level 5 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c5

    public void C6()
    {
        SceneManager.LoadScene(Scene.C6.ToString()); // loads level 6 (campaign)
        Time.timeScale = 1.0f; 
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c6

    public void C7()
    {
        SceneManager.LoadScene(Scene.C7.ToString()); // loads level 7 (campaign)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c7

    public void C8()
    {
        SceneManager.LoadScene(Scene.C8.ToString()); // loads level 8 (campaign)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c8

    public void C9()
    {
        SceneManager.LoadScene(Scene.C9.ToString()); // loads level 9 (campaign)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c9

    public void C10()
    {
        SceneManager.LoadScene(Scene.C10.ToString()); // loads level 10 (campaign)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of c10

    public void T1()
    {
        SceneManager.LoadScene(Scene.T1.ToString()); // loads level 1 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T1

    public void Resume()
    {
        pausePannel.SetActive(false); // deactivates the pause pannel
        Time.timeScale = 1.0f; // time resumes
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen

    }// end of resume

    public void Pause()
    {
        pausePannel.SetActive(true); // deactivates the pause pannel
        Time.timeScale = 0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the screen boundaries

    }// end of pause

    public void GodMode()
    {
        godmodePannel.SetActive(true);
        Time.timeScale = 0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the screen boundaries


    }// end of godmode

    public void GodModeClose()
    {
        godmodePannel.SetActive(false);
        Time.timeScale = 0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the screen boundaries


    }// end of godmode close

    public void GameOver()
    {
        gameOverPannel.SetActive(true); // activates the game over pannel
        Time.timeScale = 0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the screen boundaries

    }// end of gameover

    public void Victory()
    {
        starManager.starsAchieved(); // saves the players star score for this level
        victoryPannel.SetActive(true); // activates the victory pannel
        Time.timeScale = 0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the screen boundaries


    } // end of victory

    public void ResetData()
    {
        PlayerPrefs.DeleteAll();

    } // end of resetdata

    // HELP PAGES

    public void page1()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel1.SetActive(true); // activates the pannel   
    } // end of page 1

    public void page2()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel2.SetActive(true); // activates the pannel   
    } // end of page 2

    public void page3()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel3.SetActive(true); // activates the pannel   

    } // end of page 3

    public void page4()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel4.SetActive(true); // activates the pannel   


    } // end of page 4

    public void deactivate1()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel1.SetActive(false); // deactivates the pannel 
    } // end of deactivate

    public void deactivate2()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel2.SetActive(false); // deactivates the pannel 
    } // end of deactivate

    public void deactivate3()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel3.SetActive(false); // deactivates the pannel 
    } // end of deactivate

    public void deactivate4()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        panel4.SetActive(false); // deactivates the pannel 
    } // end of deactivate

    public void notebook1act()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook1.SetActive(true); // activates the notebook

    } // end of notebook1act

    public void notebook2act()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook2.SetActive(true); // activates the notebook

    } // end of notebook2act

    public void notebook3act()
    {

        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook3.SetActive(true); // activates the notebook

    } // end of notebook3act

    public void notebook1deact()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook1.SetActive(false); // deactivates the notebook

    } // end of notebook1deact

    public void notebook2deact()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook2.SetActive(false); // deactivates the notebook

    } // end of notebook1deact

    public void notebook3deact()
    {
        Time.timeScale = 1.0f; // time stops - prevents player from moving when paused
        Cursor.lockState = CursorLockMode.Confined; // locks the cursor in the middle of the screen
        notebook3.SetActive(false); // deactivates the notebook

    } // end of notebook1deact

    public void T2()
    {
        SceneManager.LoadScene(Scene.T2.ToString()); // loads level 2 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T2

    public void T3()
    {
        SceneManager.LoadScene(Scene.T3.ToString()); // loads level 3 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T3

    public void T4()
    {
        SceneManager.LoadScene(Scene.T4.ToString()); // loads level 4 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T4

    public void T5()
    {
        SceneManager.LoadScene(Scene.T5.ToString()); // loads level 5 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T5

    public void T6()
    {
        SceneManager.LoadScene(Scene.T6.ToString()); // loads level 6 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T6

    public void T7()
    {
        SceneManager.LoadScene(Scene.T7.ToString()); // loads level 7 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T7

    public void T8()
    {
        SceneManager.LoadScene(Scene.T8.ToString()); // loads level 8 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T8

    public void T9()
    {
        SceneManager.LoadScene(Scene.T9.ToString()); // loads level 9 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T9

    public void T10()
    {
        SceneManager.LoadScene(Scene.T10.ToString()); // loads level 10 (TT)
        Time.timeScale = 1.0f;
        Cursor.lockState = CursorLockMode.Locked; // locks the cursor in the middle of the screen
    } // end of T10



} // end of class

