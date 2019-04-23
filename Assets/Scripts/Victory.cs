using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{

    // Attributes
    public AudioClip victorySound;
    private AudioSource source;
    
    // Use this for initialization
    void Awake()
    {
        // Changes the scene to the victory one
        source = GetComponent<AudioSource>();
        source.PlayOneShot(victorySound, 1);
    }
}