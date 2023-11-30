using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class intro : MonoBehaviour
{
    void Update()
    {
        // Check if any key is pressed
        if (Input.anyKeyDown)
        {
            // Check if the pressed key is not the Escape key
            if (Input.GetKey(KeyCode.Escape))
            {
                // Exit the application
                //UnityEditor.EditorApplication.isPlaying = false;
                Application.Quit();
            }
            else
            {
                // Check which key is pressed and load the corresponding scene
                if (Input.GetKeyDown(KeyCode.Alpha1))
                {
                    SceneManager.LoadScene("intro1");
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    SceneManager.LoadScene("intro2");
                }
                /*
                else if (Input.GetKeyDown(KeyCode.Alpha3))
                {
                    SceneManager.LoadScene("intro3");
                }
                */
            }
        }
    }
}
