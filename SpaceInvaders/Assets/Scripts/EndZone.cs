using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EndZone : MonoBehaviour
{
    public EndZoneHandler handler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D col) {
        if(col.tag != "Player" && col.tag != "Bullet" && col.name != "Enemy4(Clone)") {
            if(this.gameObject.name == "EndZoneLeft") {
                handler.moveEnemies("left");
            } else {
                handler.moveEnemies("right");
            }
        } else if(col.tag == "Bullet" || col.name == "Enemy4(Clone)") {
            handler.destroyBullet(col);
        }
    }
}
