using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public float movementForce = 1000f;
    public float velocity = 10f;
    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, -movementForce * Time.deltaTime);
        var nw = new Vector3(0, 0, -1);
        rb.velocity = nw*(velocity + Time.timeSinceLevelLoad + 5);
        
    }
}
