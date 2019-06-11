using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public float spawnRatePerSec = 1f;
    public Vector3 spawnLocation;
    float floorSize = 6.0f;
    float timer;
    void Start()
    {
        timer = Time.time + 1/spawnRatePerSec;
        //spawnLocation = new Vector3(0.0f, 1.0f, 20.0f);
    }
    void FixedUpdate()
    {
        if(Time.time >= timer)
        {
            //thanks to singleton in objectpooler
            spawnLocation.x = Random.Range(-floorSize, floorSize); 
            objectPooler.Instace.SpawnFromPool("Cube", spawnLocation, Quaternion.identity);
            timer = Time.time + 1 /spawnRatePerSec; //redundancy but help to not spawn a lot of the objects when restarting the scene
        }
    }
}
