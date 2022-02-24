using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class time : MonoBehaviour
{
    public Text scoreText;

    private TimeSpan timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += System.TimeSpan.FromSeconds(Time.deltaTime);
        scoreText.text = "Time: "+ timer.ToString("mm':'ss':'ff");
    }
}
