using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Attributes
    public AudioClip gameoverSound;
    private AudioSource source;

    // Use this for initialization
    void Awake()
    {
        // Changes the scene to the gameover one
        source = GetComponent<AudioSource>();
        source.PlayOneShot(gameoverSound, 1);
        Destroy(GameObject.Find("Game Manager"));
    }
}