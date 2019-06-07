using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public float spawnRatePerSec = 1f;
    float floorSize = 6.0f;
    public float timer;
    public Vector3 spawnLocation;
    void start()
    {
        timer = Time.time + 1/spawnRatePerSec;
        spawnLocation = new Vector3(0.0f, 1.0f, 20.0f);
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
