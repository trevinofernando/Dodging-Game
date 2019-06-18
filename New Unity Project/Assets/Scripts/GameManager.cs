using System;
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
    public Text highScore;
    public string mainTheme;
    public string gameOverTheme;

    [HideInInspector]
    public Scene scene;

    void start()
    {
        Debug.Log("Loading previews High Score...");

        //Identifying what is the current Scene out of the 4 existing
        scene = SceneManager.GetActiveScene(); //MainMenu, Hell, Earth, or Heaven

    }
    public void GameOver() //public to be accessed from player collision
    {
        if (gameHasEnded == false)
        {
            int score;
            Debug.Log("Game Over");

            FindObjectOfType<AudioManager>().Stop(mainTheme);
            FindObjectOfType<AudioManager>().Play(gameOverTheme);

            gameHasEnded = true;
            gameOverScore.text = gameScore.text;

            Int32.TryParse(gameScore.text, out score); //Parse string to convert to int

            if (score > PlayerPrefs.GetInt(SceneManager.GetActiveScene().name + "HighScore",0))
            {
                PlayerPrefs.SetInt(SceneManager.GetActiveScene().name + "HighScore", score);
                highScore.text = gameOverScore.text;
            }
            else
            {
                highScore.text = PlayerPrefs.GetInt(SceneManager.GetActiveScene().name + "HighScore", 0).ToString();
            }
            
            
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
