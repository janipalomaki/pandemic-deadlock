using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class finishGameDisplay : MonoBehaviour
{
    public TextMeshProUGUI toolsText;
    public TextMeshProUGUI timeText;

    void Start()
    {
        // Retrieve tools and time data from PlayerPrefs
        int tools = PlayerPrefs.GetInt("Tools");
        float time = PlayerPrefs.GetFloat("Time");

        // Format the time into minutes and seconds
        string formattedTime = FormatTime(time);

        // Display the tools and time in the UI Text elements
        toolsText.text = "Tools: " + tools + "/9";
        timeText.text = "Time: " + formattedTime;
    }

    // Helper method to format time into minutes and seconds
    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
