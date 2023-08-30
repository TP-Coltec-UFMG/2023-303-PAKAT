using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class GameController : MonoBehaviour
{

    [SerializeField] private GameObject victoryScreen;
    public Text timeText;
    public float timeCount = 150;
    public bool timeOver = false;

    public void RefreshScreen()
    {
        timeText.text = timeCount.ToString("F0");
    }

    private void Update()
    {

        TimeCount();

    }

    void TimeCount()
    {
        
        timeOver = false;

        if (!timeOver && timeCount > 0)
        {
            timeCount -= Time.deltaTime;
            RefreshScreen();
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


