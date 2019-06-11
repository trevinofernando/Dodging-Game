using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody rb;
    //public float movementForce = 1000f;
    public float initialVelocity = 500f;
    public float maxSpeed = 1000f;
    Vector3 foward;

    void Start()
    {
        foward = new Vector3(0, 0, -1);
    }

    void FixedUpdate()
    {
        //rb.AddForce(0, 0, -movementForce * Time.deltaTime);
        if (rb.velocity.magnitude < maxSpeed)
            rb.velocity = foward * (initialVelocity + Time.timeSinceLevelLoad);
        
    }
}
