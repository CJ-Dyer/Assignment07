using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordDisplay : MonoBehaviour
{
    public Text text;

    public static int score = 0;

    public void SetWord(string word)
    {
        text.text = word;

        if (SettingsManager.TextColor == 0)
        {
            text.color = Color.black;
        } else if (SettingsManager.TextColor == 1)
        {
            text.color = Color.blue;
        } else if (SettingsManager.TextColor == 2)
        {
            text.color = Color.green;
        }
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
        score++;
    }

    private void Update()
    {
        transform.Translate(0f, -SettingsManager.FallSpeed, Time.deltaTime, 0f);
    }
}
