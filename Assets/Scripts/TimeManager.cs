using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{
    public Text remainingTimeText;

    public float timelimit = 30.0f;
    public float timeRemaining;

    void Start()
    {
        timeRemaining = timelimit;

        remainingTimeText.text = "Time Remaining: " + timeRemaining.ToString("F2");
    }

    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTimeText.text = "time remaining: " + timeRemaining.ToString("F2");
        }
        else
        {
            SceneManager.LoadScene("OutroScene");
        }

    }
}
