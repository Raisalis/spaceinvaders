using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Environment : MonoBehaviour
{
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;
    public GameObject enemy3Prefab;
    public GameObject shieldPrefab;
    public GameObject playerPrefab;
    public GameObject guide;
    public Transform enemyHandler;
    public Transform shieldHandler;
    private bool visible = true;
    private int timer = 10;
    private int currentTime;

    // Start is called before the first frame update
    void Start()
    {

        // Set-Up Initial Level
        float x = -4;
        float y = 3.5f;
        int i = 0;
        for(i = 0; i < 8; i++) {
            GameObject newObject = Instantiate(enemy3Prefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(enemyHandler);
            x += 1;
        }
        x = -4;
        y = 3f;
        for (i = 0; i < 8; i++) {
            GameObject newObject = Instantiate(enemy1Prefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(enemyHandler);
            x += 1;
        }
        x = -4;
        y = 2.5f;
        for (i = 0; i < 8; i++) {
            GameObject newObject = Instantiate(enemy1Prefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(enemyHandler);
            x += 1;
        }
        x = -4;
        y = 2f;
        for (i = 0; i < 8; i++) {
            GameObject newObject = Instantiate(enemy2Prefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(enemyHandler);
            x += 1;
        }
        x = -4;
        y = 1.5f;
        for (i = 0; i < 8; i++) {
            GameObject newObject = Instantiate(enemy2Prefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(enemyHandler);
            x += 1;
        }
        x = -8f;
        y = -2.5f;
        for(i = 0; i < 4; i++) {
            GameObject newObject = Instantiate(shieldPrefab);
            newObject.transform.position = new Vector3(x, y, 0);
            newObject.transform.SetParent(shieldHandler);
            x += 5;
        }

        x = 0f;
        y = -4.5f;
        GameObject playerObject = Instantiate(playerPrefab);
        playerObject.transform.position = new Vector3(x, y, 0);

        timer = 10;

    }

    // Update is called once per frame
    void Update()
    {
        // TODO: Hide Score Guide after 10 seconds
        currentTime = (int)(timer - Time.fixedTime);
        if(currentTime <= 0 && visible) {
            guide.SetActive(false);
            visible = false;
        } 
    }
}
