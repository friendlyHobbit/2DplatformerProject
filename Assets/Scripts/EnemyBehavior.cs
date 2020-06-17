using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{
    float randomDir;

    Collider2D floorColl;


    // Start is called before the first frame update
    void Start()
    {
        randomDir = Mathf.Round(Random.Range(-1, 1));
        print(randomDir);

        // find floor
        floorColl = GameObject.FindGameObjectWithTag("floor").GetComponent<Collider2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // give random dir
        //enemyMovement();
    }


    void playerCollision()
    {

    } 

    void enemyMovement()
    {   

    }


    // if at end of platform invert dir.x

    /*
    private void OnCollisionStay2D(Collision2D c)
    {
        if (c.collider.IsTouching(floorColl))
        {
            print("touching floor");
            //keep walking untill end of platform
            transform.position = transform.position + new Vector3(Time.deltaTime * 3, 0, 0);
        }
    }
    */

}
