using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // AUDIO SOURCES
    public AudioClip[] bgm; // used to control the bgm
    public int trackNO; // stores the number of bgm track to play
    public AudioSource sfxSource; // used to control the sfx
    public AudioSource musicSource; // used to control the sfx


    //  SOUND EFFECT CLIPS
    // stores the audio clip for each sound
    [Header("SOUND EFFECTS")]
    public AudioClip boing;
    public AudioClip collectCoin;
    public AudioClip collectSticker;
    public AudioClip drinkPeppy;
    public AudioClip hitEnemy;
    public AudioClip loose;
    public AudioClip win;
    public AudioClip playerhurt;
    public AudioClip playerDeath;

    private void Start()
    {
        musicSource.clip = bgm[trackNO]; // stores the specified background music
        musicSource.Play(); // plays the background music
    } // end of start

    public void PlaySFX(AudioClip clip) // function plays a specific audio clip
    {
        sfxSource.PlayOneShot(clip); // plays the audio clip entered


    } // end of PlaySFX


} // end of class
