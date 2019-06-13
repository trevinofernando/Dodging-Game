using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameMovement : MonoBehaviour
{
 
    public float initialDistance;
    public float minDistance; //we will assume minDistance is smaller than maxDistance
    public float maxDistance;
    public float speed;
    Vector3 vectorZ = new Vector3(0,0,1);


    void Start()
    {
        //We only want to move the flames along the z axis
        //So we will fix x = 0 and y = 1
        transform.position = new Vector3(0, 1, initialDistance);
        if(minDistance > maxDistance)
        {
            Debug.Log("Flames minDistance > maxDistance. Reseting values to default...");
            minDistance = 10f;
            maxDistance = 100f;
        }
        if(initialDistance < minDistance || initialDistance > maxDistance)
        {
            initialDistance = maxDistance - 1f;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if we are in between the boundries
        if (transform.position.z < maxDistance && transform.position.z > minDistance) 
        {
            transform.position += vectorZ * speed * Time.deltaTime;

        }
        else //we assume the start position is between min and max
        {
            speed *= -1;
            transform.position += vectorZ * 2 * speed * Time.deltaTime;
        }
        
    }
}
