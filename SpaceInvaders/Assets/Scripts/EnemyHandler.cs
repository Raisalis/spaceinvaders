using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=UnityEngine.Random;

public class EnemyHandler : MonoBehaviour
{
    private float speed = .5f;
    private String movement = "right";
    private int row = 0;

    private float timer = 10;
    private float ufospeed = 5;

    public GameObject enemy4Prefab;

    public ScoreManager scoring;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // TODO: implement random chance for ufo to spawn when row < 5
        if(row != 0) {
            int check = (int)Random.Range(0, 10);
            if(timer <= 0 && check == 0) {
                spawnUFO();
                timer = 10f;
            }
            timer -= Time.deltaTime;
        }
    }

    void FixedUpdate()
    {
        if(movement == "right") {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x + (speed * Time.deltaTime), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        } else {
            this.gameObject.transform.position = new Vector3(this.gameObject.transform.position.x - (speed * Time.deltaTime), this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
    }

    public void setMovement(String direction) {
        movement = direction;
    }

    public void increaseSpeed() {
        speed += .1f;
    }

    public void increaseRow() {
        row++;
    }

    public void addScore(int value) {
        scoring.addScore(value);
    }

    public void spawnUFO() {
        int check = (int)Random.Range(0, 2);
        float x = 0f;
        if(check == 0) {
            x = -9f;
        } else {
            x = 9f;
        }
        float y = 3.5f;
        GameObject newObject = Instantiate(enemy4Prefab);
        newObject.transform.position = new Vector3(x, y, 0);
        if(check == 0) {
            newObject.GetComponent<Rigidbody2D>().velocity = Vector2.right * ufospeed;
        } else {
            newObject.GetComponent<Rigidbody2D>().velocity = Vector2.left * ufospeed;
        }
        
    }
}
