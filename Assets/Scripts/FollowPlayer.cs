using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    public Vector2 camPos;
    Vector2 playerPos;

    // Start is called before the first frame update
    void Start()
    {
        // get player position
        playerPos = GameObject.FindGameObjectWithTag("player").transform.position;
        // get camera pos
        camPos = this.transform.position;
        // set camera to player position
        camPos = playerPos;
        
    }

    // Update is called once per frame
    void Update()
    {
        // follow player position
        camPos = playerPos;
    }
}
