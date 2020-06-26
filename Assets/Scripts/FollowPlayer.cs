using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class FollowPlayer : MonoBehaviour
{
    // allow designer to set a camera offset
    // change these values in the unity editor depending on the kind of level you´re designing
    public float camOffsetX;
    public float camOffsetY;

    Vector3 camPos;
    GameObject playerObj;


    // Start is called before the first frame update
    void Start()
    {
        // get player position
        playerObj = GameObject.FindGameObjectWithTag("player");
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player pos
        camPos = new Vector3(playerObj.transform.position.x + camOffsetX, playerObj.transform.position.y + camOffsetY, -10.0f);
        
        // follow player position, update cam
        this.transform.position = camPos;
    }
}
