using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShots : MonoBehaviour
{

	// Use this for initialization
	void Start ()
    {
        // Destroy shots after 1 sec.
        Destroy(gameObject, 1);
    }
    
    // If the shots is hits the enemy then the shots are eliminated 
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }
}