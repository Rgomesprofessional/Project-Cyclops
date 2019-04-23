using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    // Attributes
    public AudioClip presentationSound;
    public AudioClip tutorialL1;
    public AudioClip tutorialL2;
    public AudioClip tutorialL3;
    public AudioClip tutorialL4;
    public AudioClip tutorialL5;
    public AudioClip tutorialL6;
    public AudioClip tutorialL7;
    public AudioClip tutorialL8;
    public AudioClip tutorialL9;
    public AudioClip tutorialL10;
    public AudioClip tutorialL11;
    public AudioClip tutorialL12;
    public AudioClip tutorialL13;
    public AudioClip tutorialL14;
    public AudioClip tutorialL15;
    public AudioClip explosionSound;
    public AudioClip enemySound;
    public AudioClip behindSound;
    public AudioClip introSound;
    public AudioClip backgroundSound;
    public AudioClip level1;
    private AudioSource source;

    // Update is called once per frame
    void Awake()
    {
        // Call all the sound from the intro and tutorial in the correct order
        source = GetComponent<AudioSource>();
        Invoke("PlayPresentationSound", .5f);
        Invoke("PlaytutorialL1", 24f);
        Invoke("PlaytutorialL2", 29f);
        Invoke("PlayExplosionSound", 35f);
        Invoke("PlaytutorialL3", 36f);
        Invoke("PlaytutorialL4", 42f);
        Invoke("PlaytutorialL5", 47f);
        Invoke("PlayEnemyRightSound", 53f);
        Invoke("PlayEnemyRightSound", 54f);
        Invoke("PlayEnemyRightSound", 55f);
        Invoke("PlaytutorialL6", 57f);
        Invoke("PlayEnemyLeftSound", 63f);
        Invoke("PlayEnemyLeftSound", 64f);
        Invoke("PlayEnemyLeftSound", 65f);
        Invoke("PlaytutorialL7", 67f);
        Invoke("PlayEnemySound", 74f);
        Invoke("PlayEnemySound", 75f);
        Invoke("PlayEnemySound", 76f);
        Invoke("PlaytutorialL8", 78f);
        Invoke("PlayEnemySound", 85f);
        Invoke("PlayEnemySound", 86f);
        Invoke("PlayBehindSound", 86.2f);
        Invoke("PlayEnemySound", 87f);
        Invoke("PlaytutorialL9", 89f);
        Invoke("StartGame", 95f);
    }

    // Plays the sounds
    void PlayPresentationSound()
    {
        source.PlayOneShot(presentationSound, 1);
    }

    void PlaytutorialL1()
    {
        source.PlayOneShot(tutorialL1, 1);
    }

    void PlaytutorialL2()
    {
        source.PlayOneShot(tutorialL2, 1);
    }

    void PlayExplosionSound()
    {
        source.PlayOneShot(explosionSound, 1);
    }

    void PlaytutorialL3()
    {
        source.PlayOneShot(tutorialL3, 1);
    }

    void PlaytutorialL4()
    {
        source.PlayOneShot(tutorialL4, 1);
    }

    void PlaytutorialL5()
    {
        source.PlayOneShot(tutorialL5, 1);
    }

    void PlayEnemyRightSound()
    {
        source.panStereo = 1;
        source.PlayOneShot(enemySound, 1);
    }

    void PlaytutorialL6()
    {
        source.panStereo = 0;
        source.PlayOneShot(tutorialL6, 1);
    }

    void PlayEnemyLeftSound()
    {
        source.panStereo = -1;
        source.PlayOneShot(enemySound, 1);
    }

    void PlaytutorialL7()
    {
        source.panStereo = 0;
        source.PlayOneShot(tutorialL7, 1);
    }

    void PlayEnemySound()
    {
        source.PlayOneShot(enemySound, 1);
    }

    void PlaytutorialL8()
    {
        source.PlayOneShot(tutorialL8, 1);
    }

    void PlayBehindSound()
    {
        source.PlayOneShot(behindSound, 1);
    }

    void PlaytutorialL9()
    {
        source.PlayOneShot(tutorialL9, 1);
    }

    void PlaytutorialL10()
    {
        source.PlayOneShot(tutorialL10, 1);
    }

    void PlaytutorialL11()
    {
        source.PlayOneShot(tutorialL11, 1);
    }

    void PlaytutorialL12()
    {
        source.PlayOneShot(tutorialL12, 1);
    }

    void PlaytutorialL13()
    {
        source.PlayOneShot(tutorialL13, 1);
    }

    void PlaytutorialL14()
    {
        source.PlayOneShot(tutorialL14, 1);
    }

    void PlaytutorialL15()
    {
        source.PlayOneShot(tutorialL15, 1);
    }

    void PlayBackgroundSound()
    {
        source.PlayOneShot(backgroundSound, 1);
    }
    
    // Starts the game
    void StartGame()
    {
        SceneManager.LoadScene("Level1");
    }
}