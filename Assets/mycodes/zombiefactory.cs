using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieFactory : MonoBehaviour
{
    public GameObject Zombie3;  // Reference to the zombie prefab
    private float time = 0f;

    // Update is called once per frame
    void Update()
    {
        // Increment the time
        this.time += Time.deltaTime;

        // Check if it's time to create a new zombie
        if (this.time >= 15f)
        {
            // Get the terrain data
            Terrain terrain = Terrain.activeTerrain;
            TerrainData terrainData = terrain.terrainData;

            // Generate a random position on the terrain
            float randomX = Random.Range(terrain.GetPosition().x, terrain.GetPosition().x + terrainData.size.x);
            float randomZ = Random.Range(terrain.GetPosition().z, terrain.GetPosition().z + terrainData.size.z);
            Vector3 randomPosition = new Vector3(randomX, terrain.SampleHeight(new Vector3(randomX, 0f, randomZ)), randomZ);

            // Instantiate a new zombie at the random position
            Instantiate(Zombie3, randomPosition, Quaternion.identity);

            // Reset the time
            this.time = 0f;
        }
    }
}
