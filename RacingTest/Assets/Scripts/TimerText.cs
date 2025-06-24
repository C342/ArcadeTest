using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using UnityEngine;

public class TimerText : MonoBehaviour
{
    private float TimerText;

    [SerializeField] private Text stopwatchText;

    void Start()
    {
        timer = Time.time;
    }

    void Update()
    {
        float elapsed = Time.time - startTime;

        int minutes = Mathf.FloorToInt(elapsed / 60);
        int seconds = Mathf.FloorToInt(elapsed % 60);
        int milliseconds = Mathf.FloorToInt((elapsed * 100) % 100);

        if (stopwatchText != null)
        {
            stopwatchText.text = $"{minutes:D2}:{seconds:D2}.{milliseconds:D2}";
        }
        else
        {
            Debug.Log($"{minutes:D2}:{seconds:D2}.{milliseconds:D2}");
        }
    }
}