using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float fowardForce = 1000f;
    public float sideForce = 500f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Starts...");
    }

    // Update is called once per frame
    void FixedUpdate() // "FixUpdate" since we are manipulating physics
    {
        //rb.AddForce(0, 0, fowardForce * Time.deltaTime); //deltatime is number of seconds since last frame

        if( Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
