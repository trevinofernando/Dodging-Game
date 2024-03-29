﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public GameObject jumpExplosion;
    public string jumpExplosionName;
    public AudioManager audioManager;
    public float jumbForce = 1000f;
    public float sideForce = 500f;
    public string dragSound;
    bool canJump = false;
    float lastSoundTime = -1f;

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Jump Enabled");
        if (collisionInfo.collider.tag == "Floor")
        {
            canJump = true;
            audioManager.Play("HitMetal");
            //rb.velocity = Vector3.zero;
            //rb.angularVelocity = Vector3.zero;
        }
        else if(collisionInfo.collider.tag == "Obstacle")
        {
            audioManager.Play("HitStone");
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

        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (canJump && lastSoundTime + 1f < Time.timeSinceLevelLoad)//&& (Time.timeSinceLevelLoad - lastSoundTime) > .5f) //only play sound if in contact with the floor
            {
                lastSoundTime = Time.timeSinceLevelLoad;
                audioManager.Play(dragSound);
            }
        }
        else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            if (canJump && lastSoundTime + 1f < Time.timeSinceLevelLoad)//&& (Time.timeSinceLevelLoad - lastSoundTime) > .5f)//only play sound if in contact with the floor
            {
                lastSoundTime = Time.timeSinceLevelLoad;
                audioManager.Play(dragSound);
            }
        }
        else if(rb.velocity.magnitude < 0.3)
        {
            audioManager.Stop(dragSound); //if almost not moving, stop dragging sound
        }
        if (canJump && (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space)))
        {
            rb.AddForce(0, jumbForce, 0, ForceMode.Impulse); //transform.up uses the definition of "up" for the object

            Instantiate(jumpExplosion, transform.position, Quaternion.identity);
            audioManager.Play(jumpExplosionName);
            audioManager.Stop(dragSound);
        }

    }
}
