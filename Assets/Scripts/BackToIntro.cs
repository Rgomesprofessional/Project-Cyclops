using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToIntro : MonoBehaviour
{
	// Use this for initialization
    void Awake()
    {
        // Start the game again
        Invoke("StartGame", 10f);

    }

    // Start the game from the intro
    void StartGame()
    {
        SceneManager.LoadScene("Intro");
    }
}