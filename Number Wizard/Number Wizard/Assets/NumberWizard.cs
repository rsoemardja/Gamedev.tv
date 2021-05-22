using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min;
    int max;
    int guess;

    // Start is called before the first frame update
    void Start()   
    {
        StartGame();

    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log("Welcome to the game number wizard, Homie");
        Debug.Log("Pick a number, any number...");
        Debug.Log("The Highest Number you can pick is: " + max);
        Debug.Log("The Lowest Number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = lower, Push Enter = Correct");
        max = max + 1;
    }
    // Update is called once per frame
    void Update()
    {
        if  (Input.GetKeyDown(KeyCode.UpArrow))
            {
            min = guess;
            NextGuess();
        }
        else if  (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        { 
            Debug.Log("That's Correct!");
        }   
    }
    void NextGuess() 
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);

    }
}
