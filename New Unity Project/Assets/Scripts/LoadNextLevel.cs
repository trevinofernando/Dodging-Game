using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextLevel : MonoBehaviour
{
    public IEnumerator NextLevel() //This Event happens after loading the GameOver message
    {
        Time.timeScale = 0f; //Freeze time
        while (!Input.anyKey) //wait for player input 
        {
            yield return null;
        }
        //restart the game
        Time.timeScale = 1f; //return time scale to normal
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
