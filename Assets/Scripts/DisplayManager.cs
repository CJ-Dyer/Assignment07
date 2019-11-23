using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayManager : MonoBehaviour
{
    public Text NameText;
    public Text ScoreText;
    public Text MissedText;
    public Text SpeedText;

    private void Update()
    {
        NameText.text = "Player Name: " + SettingsManager.PlayerName.ToString();
        ScoreText.text = "Score: " + WordDisplay.score.ToString();
        MissedText.text = "Words Missed: " + WordDestroy.wordsMissed.ToString();
        SpeedText.text = "Fall Speed: " + SettingsManager.FallSpeed.ToString("f2");
    }
}
