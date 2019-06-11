using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Score gameScore;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        Debug.Log("Hit with " + collisionInfo.collider.name);

        //if(collisionInfo.collider.tag == "DeathBarrier")
        if(collisionInfo.collider.CompareTag("DeathBarrier")) //compareTag is more performant
        {
            FindObjectOfType<AudioManager>().Stop("Drag1");//Work around, can be improved
            movement.enabled = false;
            gameScore.stop = true;

            #region Disolving lava effect
            collisionInfo.collider.enabled = false; 
            Time.timeScale = .5f;
            #endregion

            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
