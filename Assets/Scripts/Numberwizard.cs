using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Numberwizard : MonoBehaviour
{
   [SerializeField] int max;
   [SerializeField] int min;
    [SerializeField] TextMeshProUGUI GuessText;
    int guess;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        NextGuess();
       // guess = (max + min) / 2;
        //GuessText.text = guess.ToString();
       // max = max + 1;
    }
   public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
   public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = UnityEngine.Random.Range(min, max +1);
        GuessText.text = guess.ToString();
    }
}
