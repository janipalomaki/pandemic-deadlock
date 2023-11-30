using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiefollow : MonoBehaviour

    // This code will make zombie to follow the player
{
    public Transform target; // Assign the FPS controller as the target

    public float moveSpeed = 3f;
    public float rotationSpeed = 3f;

    void Update()
    {
        if (target == null)
        {
            Debug.LogError("Target not assigned for ZombieAI script!");
            return;
        }

        // Move towards the player
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // Rotate to face the player
        Vector3 targetDir = target.position - transform.position;
        float step = rotationSpeed * Time.deltaTime;
        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}

