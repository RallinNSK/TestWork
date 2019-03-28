using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public float time; //замерение времени в секундах
    public Text text;

    private GameController gameContoller;

    public void Start()
    {
        gameContoller = FindObjectOfType<GameController>();
    }

    private void Update()
    {
        if (time >= 0 && gameContoller.useTimer)
        {
            time -= Time.deltaTime;

            string minutes = ((int)time / 60).ToString();
            string seconds = (time % 60).ToString("f0");

            text.text = minutes + ":" + seconds;
        }

        if (time <= 0)
        {
            gameContoller.useTimer = !gameContoller.useTimer;
            gameContoller.GameOver();
        }
    }
}
 