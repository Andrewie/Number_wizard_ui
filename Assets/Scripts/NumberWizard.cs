using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {


    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] Text guessText;
    int guess;
    int[] guesses;
    int guessNr;

    void Start()
    {
        StartGame();
    }

    // Use this for initialization

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess-1;
        NextGuess();
    }

    public void OnPressQuit()
    {
        Application.Quit();

    }




    void StartGame()
    {
        NextGuess();
        guessText.text = guess.ToString();
    }

    void NextGuess()
    {

        guess = Random.Range(min, max+1);
        guessText.text = guess.ToString();
    }

}
