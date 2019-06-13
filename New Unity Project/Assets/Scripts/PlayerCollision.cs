using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Score gameScore;
    public GameObject disolvingEffect;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        Debug.Log("Hit with " + collisionInfo.collider.name);

        //if(collisionInfo.collider.tag == "DeathBarrier")
        if(collisionInfo.collider.CompareTag("DeathBarrier")) //compareTag is more performant
        {
            movement.enabled = false;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            FindObjectOfType<AudioManager>().Stop("Drag1");//Work around, can be improved
            //FindObjectOfType<AudioManager>().Play("Lava"); //Death sound

            gameScore.stop = true;
            FindObjectOfType<AudioManager>().Play("BurningInLava");
            FindObjectOfType<AudioManager>().Play("GameOverEvil");

            Instantiate(disolvingEffect, transform.position, Quaternion.identity);

            #region Disolving lava effect
            collisionInfo.collider.enabled = false; 
            Time.timeScale = .5f;
            #endregion

            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
