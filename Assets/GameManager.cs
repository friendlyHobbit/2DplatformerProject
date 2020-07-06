using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum GameState {Neutral, Win, Lose};

public class GameManager : MonoBehaviour
{
    public static GameState currState = GameState.Neutral;

    Text gameStateText;


    // Start is called before the first frame update
    void Start()
    {
        // get state text
        gameStateText = GameObject.FindGameObjectWithTag("state_text").GetComponent<Text>();

        if (currState == GameState.Neutral)
        {
            // set a neutral text
            gameStateText.text = "Welcome!";
        }
        else if (currState == GameState.Win)
        {
            // set winning text
            gameStateText.text = "You win!";
        }
        else if (currState == GameState.Lose)
        {
            // set losing text
            gameStateText.text = "You lose!";
        }
    }

    

    //buttons
    public void StartLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        print("exit game");
        Application.Quit();
    }
}
