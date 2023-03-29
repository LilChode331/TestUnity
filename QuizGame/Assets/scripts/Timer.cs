using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    [SerializeField] float timeToCompleteQuestion = 30f;
    [SerializeField] float timerToShowCorrectAnswer = 10f;
    public bool loadNextQuestion;

    public float fillFraction;
    public bool isANsweringQuestion; 

    float timerValue;
    void Update()
    {
        UpdateTimer();
    }
    public void CancelTimer()
    {
        timerValue = 0;
    }
    void UpdateTimer()
    {
        timerValue -= Time.deltaTime;

        if(isANsweringQuestion)
        {
            if(timerValue > 0 )
            {
                fillFraction = timerValue / timeToCompleteQuestion;
            }
            else
            {
                isANsweringQuestion = false;
                timerValue = timerToShowCorrectAnswer;
            }


        }
        else
        {
            if(timerValue > 0 )
            {
                fillFraction = timerValue / timerToShowCorrectAnswer;
            }
            else
            {
                isANsweringQuestion = true;
                timerValue = timeToCompleteQuestion;
                loadNextQuestion = true;
            }
        }


    }
}
