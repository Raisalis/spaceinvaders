using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet1;
    public GameObject enemyBullet2;

    public Transform environment;
    public EnemyHandler handler;
    private float timer = 3;

    private Animator enemyAnimator;

    // Start is called before the first frame update
    void Start()
    {
        environment = GameObject.Find("Environment").GetComponent<Transform>();
        handler = GameObject.Find("Enemies").GetComponent<EnemyHandler>();
        enemyAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(this.gameObject.tag == "Shooter") {
            int check = (int)Random.Range(0, 4000);
            if(timer <= 0 && check == 0) {
                shoot();
                timer = 3f;
            }
            timer -= Time.deltaTime;
        }
    }

    public void hit() {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        enemyAnimator.SetTrigger("Death");
        int value = 0;
        if(this.gameObject.name == "Enemy1(Clone)") {
            value = 20;
        } else if(this.gameObject.name == "Enemy2(Clone)") {
            value = 10;
        } else if(this.gameObject.name == "Enemy3(Clone)") {
            value = 30;
        } else {
            // TODO: randomizer addition to score for ufo kills
            value = 40;
        }
        handler.addScore(value);
        handler.increaseSpeed();
        Destroy(this.gameObject, 1);
    }

    public void shoot() {

        // TODO: Randomly choose type of bullet

        // Animation
        enemyAnimator.SetTrigger("Fire");

        GameObject newObject = Instantiate(enemyBullet1);
        newObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - .25f, 0);
        newObject.transform.SetParent(environment);
    }
}
