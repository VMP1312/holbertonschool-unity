﻿using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text TimerText;
    public Text FinalTimer;
    private float startTime;
    float time = 0.0f;
    public GameObject TimeCanvas;

    // Start is called before the first frame update
    public void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        TimeCalculation();
    }

    public string TimeCalculation()
    {
        time = Time.time - startTime;
        int minutes = ((int)time / 60);
        int seconds = ((int)time % 60);
        float milsec = Mathf.Floor((time * 100 % 100));
        return (TimerText.text = string.Format("{0}:{1:00}.{2:00}", minutes, seconds, milsec));
    }
    public void Win()
    {
        Time.timeScale = 1f;
        TimeCanvas.SetActive(false);
        FinalTimer.text = TimeCalculation();
    }
}
