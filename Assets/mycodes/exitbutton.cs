using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Find the Button component on this GameObject
        Button exitButton = GetComponent<Button>();

        // Check if the Button component exists
        if (exitButton != null)
        {
            // Add a listener to the button click event
            exitButton.onClick.AddListener(OnExitButtonClick);
        }
        else
        {
            Debug.LogError("ExitButton script is missing the Button component!");
        }
    }

    // Function to handle the button click event
    void OnExitButtonClick()
    {
        Debug.Log("Exiting the game");
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();

    }
}