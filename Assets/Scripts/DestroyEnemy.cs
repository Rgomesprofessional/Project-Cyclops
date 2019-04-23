using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour
{
    // Use this for initialization
    void Start ()
    {
        // Destroy object after 40 secs
        Destroy(gameObject, 40);
    }

    // Activate when some collision happens
    void OnCollisionEnter(Collision col)
    {
        // If the enemy is hitten by the shots then the enemy is eliminated 
        if (col.gameObject.tag == "Shots")
        {
            GameManager.changeLevel = true;
            GameManager.enemiesDefeated++;
            GameManager.activateExplosionSound = true;

            Destroy(gameObject);
        }

        // If the enemy is hitten by other enemies then the enemies are eliminated 
        if (col.gameObject.tag == "Enemy")
        {
            GameManager.activateExplosionSound = true;
            Destroy(gameObject);
        }

        // If the enemy is hitten by the main character then the enemy is eliminated        
        if (col.gameObject.tag == "Player")
        {
            GameManager.activateExplosionSound = true;
            Destroy(gameObject);
        }
    }
}