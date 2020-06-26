using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{

    public float speed;
    public Transform childTrans;
    float enemyDir = 1.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement();
    }


    void playerCollision()
    {

    } 


    void enemyMovement()
    {
        transform.position = transform.position + Vector3.right * Time.deltaTime * speed * enemyDir;

        // check if child spots the floor
        RaycastHit2D floorInfo = Physics2D.Raycast(childTrans.position, Vector2.down, 0.5f);
        print(floorInfo.collider);
        if (floorInfo.collider == false)
        {
            // flip
            enemyDir = enemyDir * -1.0f;
            transform.localScale = new Vector3(enemyDir,1,1);

        }
        
    }



}
