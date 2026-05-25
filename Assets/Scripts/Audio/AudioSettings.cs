using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettings : MonoBehaviour
{
 // variables
    [SerializeField] private AudioMixer audioMixer; // used to store the audio mixer
    [SerializeField] private Slider masterSlider; // stores the master slider Go
    [SerializeField] private Slider musicSlider; // stores the music slider Go
    [SerializeField] private Slider sfxSlider; // stores the sfx slider Go

    private void Start()
    {
        if(PlayerPrefs.HasKey("musicVolume")) // loads the last saved music settings - if they have been changed
        {
            LoadVolume();
        }
        else
        {
            SetMusicVolume(); // calls set music volume function
            SetSFXVolume();  // calls the set sfx function
            SetMasterVolume(); // calls the set master volume function
        }

    } // end of start

    public void SetMusicVolume()
    {
        float volume = musicSlider.value; // stores the volume as a float value
        audioMixer.SetFloat("music", Mathf.Log10(volume)*20); // updates the music volume using the value of the slider
        PlayerPrefs.SetFloat("musicVolume", volume); // stores the value of volume to be used in saving the players audio settings

    } // end of set music volume

    public void SetSFXVolume()
    {
        float volume = sfxSlider.value; // stores the volume as a float value
        audioMixer.SetFloat("sfx", Mathf.Log10(volume) * 20); // updates the sfx volume using the value of the slider
        PlayerPrefs.SetFloat("sfxVolume", volume); // stores the value of volume to be used in saving the players audio settings

    } // end of set sfx volume

    public void SetMasterVolume()
    {
        float volume = masterSlider.value; // stores the volume as a float value
        audioMixer.SetFloat("master", Mathf.Log10(volume) * 20); // updates the master volume using the value of the slider
        PlayerPrefs.SetFloat("masterVolume", volume); // stores the value of volume to be used in saving the players audio settings
    } // end of setmastervolume

    private void LoadVolume()
    {
        musicSlider.value = PlayerPrefs.GetFloat("musicVolume"); // sets the volume of the music to the value saved
        sfxSlider.value = PlayerPrefs.GetFloat("sfxVolume"); // sets the volume of the sfx to the value saved
        masterSlider.value = PlayerPrefs.GetFloat("sfxVolume"); // sets the master volume to the value saved
        SetMusicVolume(); // calls set music volume function
        SetSFXVolume(); // calls the set sfx function
        SetMasterVolume(); // calls the set master volume function
    }


} // end of class
