using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Score gameScore;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        Debug.Log("Hit with " + collisionInfo.collider.name);

        if(collisionInfo.collider.tag == "DeathBarrier")
        {
            movement.enabled = false;
            gameScore.stop = true;
            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
