using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList;

    public static string GetRandomWord()
    {
        string path = "Assets/Resources/Words.txt";

        wordList = File.ReadAllLines(path);

        int randomIndex = Random.Range(0, wordList.Length);
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
