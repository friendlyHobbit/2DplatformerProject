using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed;

    float playerDir;

    Collider2D goalColl;
    Collider2D spikeColl;
    //Collider2D enemyWeakspotColl;


    // Start is called before the first frame update
    void Start()
    {
        //find goal
        goalColl = GameObject.FindGameObjectWithTag("goal").GetComponent<Collider2D>();
        // find spikes
        spikeColl = GameObject.FindGameObjectWithTag("spike").GetComponent<Collider2D>(); //will only get one spike object, if there are more they wont be recognized
    }

    // Update is called once per frame
    void Update() //use FixedUpdate for player movement
    {
        playerMovement();


    }


    void playerMovement()
    {
        // player presses left arrow
        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A)) //Use input.getaxisraw to calculate movement
        {
            playerDir = 1.0f;
            transform.localScale = new Vector3(playerDir, 1, 1);
            transform.position = transform.position + Vector3.left * Time.deltaTime * playerSpeed;
        }
        // player presses right arrow
        else if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            playerDir = -1.0f;
            transform.localScale = new Vector3(playerDir, 1, 1);
            transform.position = transform.position + Vector3.right * Time.deltaTime * playerSpeed;
        }
    }


    // collision
    void OnCollisionEnter2D(Collision2D c)
    {
        // when playerColl enters goal
        if (c.collider == goalColl)
        {
            GameManager.currState = GameState.Win;
            // send to next level
            SceneManager.LoadScene(0);
        }
        // when playerColl touches spikes
        else if (c.collider == spikeColl)
        {
            GameManager.currState = GameState.Lose;
            // send to next level
            SceneManager.LoadScene(0);
        }
    }


}
