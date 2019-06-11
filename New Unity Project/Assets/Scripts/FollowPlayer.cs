using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Update is called once per frame
    void Update()
    {
        if(player.position.y > 0) //don't follow player below lava
        {
            transform.position = player.position + offset; //transform with lowercase referst to THIS object
        }
    }
}
