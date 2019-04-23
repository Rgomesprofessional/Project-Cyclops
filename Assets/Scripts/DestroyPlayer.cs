using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
    // Activate when some collision happens
    void OnCollisionEnter(Collision col)
    {
        // If the main character is hitten by the enemy then the main character is eliminated 
        if (col.gameObject.tag == "Enemy")
        {      
            GameManager.activateExplosionSound = true;
            GameManager.playerDefeated++;
        }
    }
}