using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EndZoneHandler : MonoBehaviour
{
    public GameObject enemies;
    public ScoreManager scoring;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void moveEnemies(String side) {
        enemies.transform.position = new Vector3(enemies.transform.position.x, enemies.transform.position.y - .25f, enemies.transform.position.z);
        if(enemies.transform.position.y < -5) {
            scoring.gameOver();
        }
        EnemyHandler enemyHandler = enemies.GetComponent<EnemyHandler>();
        if(side == "left") {
            enemyHandler.setMovement("right");
        } else {
            enemyHandler.setMovement("left");
        }
        enemyHandler.increaseRow();
    }

    public void destroyBullet(Collider2D col) {
        Destroy(col.gameObject);
    }

}
