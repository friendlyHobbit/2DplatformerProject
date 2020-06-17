using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //buttons
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        print("exit game");
        Application.Quit();
    }
}
