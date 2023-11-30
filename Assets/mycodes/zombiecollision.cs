using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class zombiecollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Add logic here
            Debug.Log("Player attacked by zombie");

            // Change to the "gameover" scene
            SceneManager.LoadScene("gameover");
        }
    }
}