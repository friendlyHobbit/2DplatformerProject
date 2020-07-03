using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float playerSpeed = 10.0f;

    float playerDir;

    Collider2D playerColl;
    Collider2D enemyColl;
    Collider2D goalColl;
    Collider2D spikeColl;
    //Collider2D enemyWeakspotColl;


    // Start is called before the first frame update
    void Start()
    {
        // find player
        playerColl = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();
        // find enemy
        enemyColl = GameObject.FindGameObjectWithTag("enemy").GetComponent<Collider2D>();
        // find enemy weakspot
        //enemyWeakspotColl = GameObject.FindGameObjectWithTag("weakness").GetComponent<Collider2D>();
        //print(enemyWeakspotColl);
        //find goal
        goalColl = GameObject.FindGameObjectWithTag("goal").GetComponent<Collider2D>();
        // find spikes
        spikeColl = GameObject.FindGameObjectWithTag("spike").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();


    }


    void playerMovement()
    {
        // player presses left arrow
        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            playerDir = 1.0f;
            transform.localScale = new Vector3(playerDir, 1, 1);
            transform.position = transform.position + Vector3.left * Time.deltaTime * playerSpeed;
        }
        // player presses right arrow
        else if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.K))
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
            // send to next level
            SceneManager.LoadScene(0);
        }
        // when playerColl touches spikes
        else if (c.collider == spikeColl)
        {
            // send to next level
            SceneManager.LoadScene(0);
        }
    }


}
