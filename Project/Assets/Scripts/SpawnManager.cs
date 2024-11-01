using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 1.245f; // Half the width of the road (2.49 / 2)
    private float minSpawnPosZ = 20.0f; // Start of the road
    private float maxSpawnPosZ = 300.0f; // End of the road
    private float startDelay = 0.25f;
    private float spawnInterval = 0.25f;

    // Optional: Define specific Z positions for more controlled spawning
    private float[] spawnPositionsZ = new float[] { 20.0f, 25.0f, 30.0f, 35.0f, 40.0f, 45.0f, 50.0f }; // Add more as needed

    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    void SpawnRandomCar()
    {
        // Random X position within the road width
        float spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        
        // Option 1: Random Z position within the defined road limits
         float spawnPosZ = Random.Range(minSpawnPosZ, maxSpawnPosZ);


        // Clamp the Z position to ensure it stays within the road bounds
        spawnPosZ = Mathf.Clamp(spawnPosZ, minSpawnPosZ, maxSpawnPosZ);

        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        int carIndex = Random.Range(0, carPrefabs.Length);
        Instantiate(carPrefabs[carIndex], spawnPos, carPrefabs[carIndex].transform.rotation);
    }
}
