using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class timing : MonoBehaviour
{
    bool stopwatchActive = false;
    float currentTime;
    public Text currentTimeText;
    
    private TimeSpan timer;

    int score;
    public Text scoreText;
    public float multiplier = 5;
    void Start()
    {
        currentTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += System.TimeSpan.FromSeconds(Time.deltaTime);
        scoreText.text = "Time: " + timer.ToString("mm':'ss':'ff");
        if (stopwatchActive == true)
        {
            currentTime = currentTime + Time.deltaTime;
        }
        score = Mathf.RoundToInt(currentTime * multiplier);
        scoreText.text = score.ToString();
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString() + ":" + time.Milliseconds.ToString();    
    }

    public void StartStopwatch()
    {
        stopwatchActive = true;
    }

    public void StopStopwatch()
    {
        stopwatchActive = false;
    }
}
