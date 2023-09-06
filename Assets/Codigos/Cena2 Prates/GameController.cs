using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private GameObject victoryScreen;
    public Text timeText;
    public float timeCount;
    public bool timeOver = false;

    void Start(){
        if(Dificuldade.dific !=0 ){
        timeCount *= Dificuldade.dific;   
        }
    }

    private void Update()
    {
        timeText.text = "Tempo: " + timeCount.ToString("F0");
        TimeCount();
    }

    void TimeCount()
    {
        timeOver = false;

        if (!timeOver && timeCount > 0)
        {
            timeCount -= Time.deltaTime;
            //RefreshScreen();
            timeOver = true;
        }

        if (timeCount <= 0 && !timeOver)
        {
            timeOver = true;
            victoryScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}


