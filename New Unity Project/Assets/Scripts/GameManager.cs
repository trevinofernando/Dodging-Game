using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public float restartDelay = 1f;
    public GameObject gameOverUI;
    public Text gameScore;
    public Text gameOverScore;

    public void GameOver() //public to be accessed from player collision
    {
        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            FindObjectOfType<AudioManager>().Stop("MainTheme");
            FindObjectOfType<AudioManager>().Play("GameOverTheme");
            gameHasEnded = true;
            gameOverScore.text = gameScore.text;
            gameOverUI.SetActive(true);
            //RestartGame();
            //Invoke("RestartGame", restartDelay);
        }
    }

    void RestartGame()
    {
        gameHasEnded = false;
        //SceneManager.LoadScene("Level1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
