using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSensor : MonoBehaviour
{
    // Attributes
    public AudioClip behindSound;
    private AudioSource source;
    
    // Use this for initialization
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    // It plays the support sound when there is enemy behind the main character 
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            source.PlayOneShot(behindSound, 1);
        }
    }
}