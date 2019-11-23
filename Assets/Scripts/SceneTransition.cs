using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void PlayGame()
    {
        WordDisplay.score = 0;
        WordDestroy.wordsMissed = 0;
        SceneManager.LoadScene("MainScene");
    }

    public void MainMenu()
    {
        WordDisplay.score = 0;
        WordDestroy.wordsMissed = 0;
        SceneManager.LoadScene("IntroScene");
    }

    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
