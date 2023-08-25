using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public Text timeText; 
    public float timeCount;
    public bool timeOver = false;

public void RefreshScreen(){

    timeText.text = timeCount.ToString("F0");

}

private void Update(){

    TimeCount();

}

void TimeCount(){

    timeOver = false;

    if (!timeOver && timeCount > 0)
    {
        timeCount -= Time.deltaTime;
        RefreshScreen();
        timeOver = true;
    }

}

}


