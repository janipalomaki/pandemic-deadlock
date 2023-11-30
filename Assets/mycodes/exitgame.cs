using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitgame : MonoBehaviour
{
    void Update()
    {
        // Check if the player pressed the "Escape" key
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Returning to intro scene");

            // Load the "intro" scene
            SceneManager.LoadScene("intro");
        }
    }
}