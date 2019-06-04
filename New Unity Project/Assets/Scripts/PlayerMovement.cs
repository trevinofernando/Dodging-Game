using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float jumbForce = 1000f;
    public float sideForce = 500f;
    bool canJump = false;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Jump Enabled");
        if (collisionInfo.collider.tag == "Floor")
        {
            canJump = true;
        }
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        Debug.Log("Jump Disabled");
        if (collisionInfo.collider.tag == "Floor")
        {
            canJump = false;
        }
    }

    // Update is called once per frame
    void FixedUpdate() // "FixUpdate" since we are manipulating physics
    {
        //rb.AddForce(0, 0, fowardForce * Time.deltaTime); //deltatime is number of seconds since last frame

        if( Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (canJump && (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)))
        {
            rb.AddForce(0, jumbForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
    }
}
