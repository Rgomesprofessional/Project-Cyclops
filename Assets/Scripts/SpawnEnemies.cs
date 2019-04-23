using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnemies : MonoBehaviour
{
    // Attributes
    public Rigidbody enemyPrefab;
    public Transform[] enemySpawner;
    public bool activator;
    private Scene currentScene;

    // Use this for initialization
    void Start ()
    {
        // Takes the current scene
        currentScene = SceneManager.GetActiveScene();

        // Spawn the enemies i different speed accordind to each level of the game
        if (currentScene.name == "SampleScene")
        {
            InvokeRepeating("switchActivator", 10, 10);
        }

        if (currentScene.name == "Level1")
        {
            InvokeRepeating("switchActivator", 10, 10);
        }

        if (currentScene.name == "Level2")
        {
            InvokeRepeating("switchActivator", 10, 5);
        }

        if (currentScene.name == "Level3")
        {
            InvokeRepeating("switchActivator", 10, 3);
        }

        activator = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Call next enemy
        if (activator)
        {
            spawnNext();
        }
    }
    
    // Spawn enemies in a random order and diferent positions
    public void spawnNext()
    {
        int i = Random.Range(0, enemySpawner.Length);

        Rigidbody enemyInstance;
        enemyInstance = Instantiate(enemyPrefab, enemySpawner[i].position, enemySpawner[i].rotation) as Rigidbody;

        // Change the speed of the enemy accornding to each level from the game
        if (currentScene.name == "Level1")
        {
            enemyInstance.AddForce(enemySpawner[i].forward * 200);
        }

        if (currentScene.name == "Level2")
        {
            enemyInstance.AddForce(enemySpawner[i].forward * 350);
        }

        if (currentScene.name == "Level3")
        {
            enemyInstance.AddForce(enemySpawner[i].forward * 500);
        }

        activator = false;
    }

    // Switch to pawn enemies
    public void switchActivator()
    {
        activator = true;
    }
}