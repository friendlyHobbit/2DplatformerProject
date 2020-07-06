using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehavior : MonoBehaviour
{

    public float enemySpeed;
    public Transform childTrans;
    float enemyDir = 1.0f;

    Collider2D playerColl;


    // Start is called before the first frame update
    void Start()
    {
        // find enemy
        playerColl = GameObject.FindGameObjectWithTag("player").GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyMovement(enemySpeed);
    }


    void enemyMovement(float speed)
    {
        transform.position = transform.position + Vector3.right * Time.deltaTime * speed * enemyDir;

        // check if child spots the floor
        RaycastHit2D floorInfo = Physics2D.Raycast(childTrans.position, Vector2.down, 1.0f);
        if (floorInfo.collider == false)
        {
            // flip
            enemyDir = enemyDir * -1.0f;
            transform.localScale = new Vector3(enemyDir,1,1);

        }
    }

    void OnCollisionEnter2D(Collision2D c)
    {
        // when playerColl enters enemyColl
        if (c.collider == playerColl)
        {
            SceneManager.LoadScene(0);
        }
    }

}
