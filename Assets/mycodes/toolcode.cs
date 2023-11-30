using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This code will add a tool to the tool counter after the player finds the survival tool

public class ToolCode : MonoBehaviour
{
    public AudioClip collectSound; // Drag and drop the audio clip in the Unity editor
    public float volume = 2.0f; // Adjust the volume level as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // If collider is the player
        {
            // Update counter 
            GameObject.Find("mycodes").GetComponent<counter>().tools++;

            Debug.Log("Tool collected");

            // Play the collect sound with the specified volume
            if (collectSound != null)
            {
                AudioSource.PlayClipAtPoint(collectSound, transform.position, volume);
            }

            Destroy(this.gameObject);
        }
    }
}
