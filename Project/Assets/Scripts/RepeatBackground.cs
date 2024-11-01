using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    public GameObject ROAD; // Starting position of the road segment
    Vector3 nextSpawnPoint;


       public  void SpawnTile()
    {
        GameObject temp = Instantiate(ROAD, nextSpawnPoint, Quaternion.identity);//no rotation
        nextSpawnPoint =temp.transform.GetChild(1).transform.position;
    }
    void Start()
    {
        for(int i =0;i < 15; i++){

        SpawnTile();

        }
        
    }
    }

   
