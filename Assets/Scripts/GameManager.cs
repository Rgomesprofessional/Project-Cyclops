using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Attributes
    public static GameManager instance = null;
    public static int enemiesDefeated = 0;
    public static int playerDefeated = 0;
    public static bool changeLevel;
    public static bool activateExplosionSound;
    public AudioClip backgroundSound;
    public AudioClip explosionSound;
    public AudioClip level2;
    public AudioClip level3;
    private AudioSource source;
    private int currentLevel;
    private Scene currentScene;

    // Call when the script is alive
    void Awake()
    {
        // Singleton pattern. Make sure the GameManager script just run in the properly moment
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        //Don't destroy the script when reloading scene
        DontDestroyOnLoad(gameObject);
        
        // Play background sound
        source = GetComponent<AudioSource>();
        source.PlayOneShot(backgroundSound, 1);
    }
    
    // Use this for initialization
    void Start ()
    {
        // Switch to keep the explosion sound off
        activateExplosionSound = false;
    }

	// Update is called once per frame
	void Update ()
    {
        // Get name of the scene
        currentScene = SceneManager.GetActiveScene();
       
        // Switch to turn on the splosion sound
        if (activateExplosionSound)
        {
            source.PlayOneShot(explosionSound, 1);
            activateExplosionSound = false;
        }

        // Change levels according to the number of enemies defeated
        if (changeLevel && enemiesDefeated == 3)
        {
            SceneManager.LoadScene("Level2");
            changeLevel = false;
        }
                
        if (changeLevel && enemiesDefeated == 8)
        {
            SceneManager.LoadScene("Level3");
            changeLevel = false;
        }

        if (changeLevel && enemiesDefeated == 15)
        {
            SceneManager.LoadScene("Victory");
            changeLevel = false;
        }

        if (playerDefeated == 3)
        {
            SceneManager.LoadScene("GameOver");
            playerDefeated = 0;
        }

        // Call a new scene if the player lose or win in the game.
        if (currentScene.name == "GameOver" || currentScene.name == "Victory")
        {
            source.volume = 0;
        } else
        {
            source.volume = 1;
        }
    }
}