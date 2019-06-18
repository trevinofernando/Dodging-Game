using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject settingsMenu;
    public static bool gameIsPaused = false;
    public AudioMixer audioMixer;
    public TextMeshProUGUI volumeText;
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Loading Player Preferences...");

        //Retriving previews Volume settings
        volumeText.text = (int)PlayerPrefs.GetFloat("Volume", 0.8f) * 100 + " %";
        volumeSlider.value = PlayerPrefs.GetFloat("Volume", 0.8f);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown("q") || Input.GetKeyDown("p"))
        {
            if (gameIsPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
        pauseMenu.SetActive(true);
    }
    public void ResumeGame()
    {
        gameIsPaused = false;
        pauseMenu.SetActive(false);
        settingsMenu.SetActive(false);
        Time.timeScale = 1f;
    }
    public void GoToMenu()
    {
        Time.timeScale = 1f; //adjust the time scale before leaving
        SceneManager.LoadScene(0);
    }
    public void UpdateVolume(float volume)
    {
        volumeText.text = (int)(volume * 100) + "%";
        audioMixer.SetFloat("Volume", volume * 100 - 80f); //subtract 80 to match mixer format range of -80 to 20
        PlayerPrefs.SetFloat("Volume", volume);
    }
    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
    public void QuitGame()
    {
        Debug.Log("Quitting game... Bye :C ");
        Application.Quit();
    }
}
