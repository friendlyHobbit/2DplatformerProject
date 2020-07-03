using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weakness : MonoBehaviour
{
    Collider2D playerColl;

    GameObject enemyObj;
    Collider2D enemyColl;


    // Start is called before the first frame update
    void Start()
    {
        playerColl = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();
        
        enemyObj = this.transform.parent.gameObject;
        enemyColl = enemyObj.GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnCollisionEnter2D(Collision2D c)
    {
        // when playerColl enters enemy´s weak spot
        if (c.collider == playerColl)
        {
            // destroy enemey
            Destroy(enemyObj.gameObject);
            print("kill");
        }
    }
}
