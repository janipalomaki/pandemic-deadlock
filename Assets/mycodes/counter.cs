using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class counter : MonoBehaviour
{
    private float timeCounter = 360f;
    public int tools = 0;
    public GameObject t1 = null;
    public GameObject t2 = null;

    void Update()
    {
        this.timeCounter -= Time.deltaTime;
        string formattedTime = FormatTime(this.timeCounter);
        this.t1.GetComponent<TextMeshProUGUI>().text = "Time: " + formattedTime;
        this.t2.GetComponent<TextMeshProUGUI>().text = "Tools: " + this.tools + "/9";

        if (timeCounter < 1f)
        {
            PlayerPrefs.SetInt("Tools", this.tools);
            PlayerPrefs.SetFloat("Time", this.timeCounter);
            SceneManager.LoadScene("gameover");
        }

        if (tools == 9)
        {
            PlayerPrefs.SetInt("Tools", this.tools);
            PlayerPrefs.SetFloat("Time", this.timeCounter);
            SceneManager.LoadScene("finishgame");
        }
    }

    string FormatTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        return string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
