using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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



}
