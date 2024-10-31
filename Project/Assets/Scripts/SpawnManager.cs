using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 25.0f;
    private float minSpawnPosZ = 20.0f;
    private float maxSpawnPosZ = 75.0f;
    private float startDelay = 1f;
    private float spawnInterval = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRandomCar(){
        // random spawn position in a defined range 
         Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,Random.Range(minSpawnPosZ, maxSpawnPosZ));
            int carIndex = Random.Range(0,carPrefabs.Length);
            Instantiate(carPrefabs[carIndex], spawnPos,
            carPrefabs[carIndex].transform.rotation);

    }
        
    }

