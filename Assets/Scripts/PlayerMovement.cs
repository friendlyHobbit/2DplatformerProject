﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Collider2D playerColl;
    Collider2D enemyColl;
    Collider2D goalColl;


    // Start is called before the first frame update
    void Start()
    {
        // find player
        playerColl = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();
        // find enemy
        enemyColl = GameObject.FindGameObjectWithTag("enemy").GetComponent<Collider2D>();
        //find goal
        goalColl = GameObject.FindGameObjectWithTag("goal").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement();


    }


    void playerMovement()
    {
        // player presses left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = transform.position + new Vector3(-Time.deltaTime * 5, 0, 0);
        }
        // player presses right arrow
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = transform.position + new Vector3(Time.deltaTime * 5, 0, 0);
        }
    }


    // collision
    void OnCollisionEnter2D(Collision2D c)
    {
        // when playerColl enters enemyColl
        if (c.collider == enemyColl)
        {
            SceneManager.LoadScene(0);
        }
        // when playerColl enters goal
        else if (c.collider == goalColl)
        {
            SceneManager.LoadScene(0);
        }
    }


}
