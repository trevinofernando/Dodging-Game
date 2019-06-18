using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public Score gameScore;
    public GameObject deathEffect;
    public AudioManager audioManager;
    public string gameOverSound;
    public string deathSound;
    public string dragSound;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        
        Debug.Log("Hit with " + collisionInfo.collider.name);

        //if(collisionInfo.collider.tag == "DeathBarrier")
        if(collisionInfo.collider.CompareTag("DeathBarrier")) //compareTag is more performant
        {
            movement.enabled = false;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

            audioManager.Stop(dragSound);//Work around, can be improved
            //audioManager.Play("Lava"); //Death sound

            gameScore.stop = true;

            if (!deathSound.Equals("None"))
            {
                audioManager.Play(deathSound);//("BurningInLava");
            }
            if (!gameOverSound.Equals("None"))
            {
                audioManager.Play(gameOverSound); //("GameOverEvil");
            }

            if(deathEffect != null)
            {
                Instantiate(deathEffect, transform.position, Quaternion.identity);
                #region Disolving lava effect
                collisionInfo.collider.enabled = false; 
                Time.timeScale = .5f;
                #endregion
                
            }


            FindObjectOfType<GameManager>().GameOver();

        }
    }
}
