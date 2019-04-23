using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroBackgroundSound : MonoBehaviour
{
    // Attributes
    public AudioClip backgroundSound;
    private AudioSource source;
    
    // Use this for initialization
    void Awake ()
    {
        // Calls background sound
        source = GetComponent<AudioSource>();
        InvokeRepeating("PlayBackgroundSound", 15f, 16f);
    }

    // Plays background sound
    void PlayBackgroundSound()
    {
        source.PlayOneShot(backgroundSound, 1);
    }
}