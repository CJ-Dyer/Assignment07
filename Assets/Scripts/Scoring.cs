using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    public Text TotalScoreText;
    public Text ScoreText;
    public Text MissedWordsText;
    public Text PlayerNameText;
    public Text HighScoreText;

    private int TotalScore;

    void Start()
    {
        string path = "Assets/Resources/Scores.txt";

        if (SettingsManager.TextColor == 0)
        {
            TotalScoreText.color = Color.black;
            ScoreText.color = Color.black;
            MissedWordsText.color = Color.black;
            PlayerNameText.color = Color.black;
            HighScoreText.color = Color.black;
        }
        else if (SettingsManager.TextColor == 1)
        {
            TotalScoreText.color = Color.blue;
            ScoreText.color = Color.blue;
            MissedWordsText.color = Color.blue;
            PlayerNameText.color = Color.blue;
            HighScoreText.color = Color.blue;
        }
        else if (SettingsManager.TextColor == 2)
        {
            TotalScoreText.color = Color.green;
            ScoreText.color = Color.green;
            MissedWordsText.color = Color.green;
            PlayerNameText.color = Color.green;
            HighScoreText.color = Color.green;
        }

        TotalScore = WordDisplay.score - WordDisplay.wordsMissed;

        if (File.Exists(path))
        {
            string[] createText = {  SettingsManager.PlayerName + "," + TotalScore.ToString() };
            File.AppendAllLines(path, createText);
        }
        else
        {
            Debug.Log("File does not exist.");
        }

        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Debug.Log(s);
            HighScoreText.text += "\n" + s;
        }

        TotalScoreText.text = "Total Score: " + TotalScore.ToString();
        ScoreText.text = "Score: " + WordDisplay.score.ToString();
        MissedWordsText.text = "Words Missed: " + WordDisplay.wordsMissed.ToString();
        PlayerNameText.text = SettingsManager.PlayerName;
    }
}
