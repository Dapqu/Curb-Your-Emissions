using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Timer instance;// we can use this to call the timer functions

    public TextMeshProUGUI timeCounter;

    private TimeSpan timePlaying;

    private bool timerOn;

    private float timeSpent;

    private void Awake(){//creates a timer object at the start of the program
        instance = this;
    }

    private void Start(){
        timeCounter.text = "Time Played: 00:00.00";
        timerOn = false;
    }

    public void BeginTimer(){
        timerOn = true;
       
        timeSpent = 0f;

        StartCoroutine(UpdateTimer());
    }

    public void EndTimer(){

        timerOn = false;
    
    }
    private IEnumerator UpdateTimer(){

        while(timerOn){

            timeSpent += Time.deltaTime;//get time between frames
            timePlaying = TimeSpan.FromSeconds(timeSpent);//add to total time
            string displayTime = "Time Played: " + timePlaying.ToString("hh':'mm'.'ss"); // convert time to a string
            timeCounter.text = displayTime;

            yield return null;
        }
    
    }




}
