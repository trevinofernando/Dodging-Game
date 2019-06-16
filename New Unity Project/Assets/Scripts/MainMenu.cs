using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using TMPro; //Text Mesh Pro import

public class MainMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public TextMeshProUGUI volumeText;
    public int sceneIndex;
    public GameObject hellImg;
    public GameObject earthImg;
    public GameObject heavenImg;
    public GameObject playButton;
    public void PlayGame()
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game... Bye :C ");
        Application.Quit();
    }


    public void LevelSelect(int levelIndex) // 1 = Hell, 2 = Earth, 3 = Heaven
    {
        sceneIndex = levelIndex;
        switch (levelIndex)
        {
            case 1:
                hellImg.transform.SetAsLastSibling();
                break;
            case 2:
                earthImg.transform.SetAsLastSibling();
                break;
            case 3:
                heavenImg.transform.SetAsLastSibling();
                break;
        }
        playButton.transform.SetAsLastSibling();
    }
    public void UpdateVolume(float volume)
    {
        volumeText.text = (int)(volume * 100) + "%";
        audioMixer.SetFloat("Volume", volume*100 -80f); //subtract 80 to match mixer format range of -80 to 20
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullScreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
