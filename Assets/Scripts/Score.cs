using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score = 0;
    public bool stop = false;

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            //score = Time.timeSinceLevelLoad * 10f;
            scoreText.text = (Time.timeSinceLevelLoad * 10).ToString("0");
        }
    }
}

