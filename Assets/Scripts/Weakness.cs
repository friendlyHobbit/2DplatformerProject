using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weakness : MonoBehaviour
{
    Collider2D playerColl;

    GameObject enemyObj;


    // Start is called before the first frame update
    void Start()
    {
        playerColl = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();
        
        enemyObj = this.transform.parent.gameObject;
    }


    void OnTriggerEnter2D(Collider2D c)
    {
        // when playerColl enters enemy´s weak spot
        if (c == playerColl)
        {
            // destroy enemey
            Destroy(enemyObj.gameObject);
        }
    }
}
