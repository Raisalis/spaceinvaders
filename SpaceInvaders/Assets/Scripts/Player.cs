using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform environment;
    public GameObject playerBulletPrefab;
    public ScoreManager scoring;

    private Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        environment = GameObject.Find("Environment").GetComponent<Transform>();
        scoring = GameObject.Find("ScoringManager").GetComponent<ScoreManager>();
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) {
            shoot();
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKey(KeyCode.LeftArrow)) {
            this.gameObject.transform.position = new Vector3(this.transform.position.x - (6f * Time.deltaTime), this.transform.position.y, 0);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKey(KeyCode.RightArrow)) {
            this.gameObject.transform.position = new Vector3(this.transform.position.x + (6f * Time.deltaTime), this.transform.position.y, 0);
        }
    }

    public void shoot() {
        bool fired = false;
        if(environment.childCount > 0) {
            foreach(Transform child in environment) {
                if(child.gameObject.name == "PlayerBullet" || child.gameObject.name == "PlayerBullet(Clone)") {
                    fired = true;
                }
            }
        }
        if(!fired) {
            playerAnimator.SetTrigger("Fire");
            GameObject newObject = Instantiate(playerBulletPrefab);
            newObject.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + .25f, 0);
            newObject.transform.SetParent(environment);
        }
    }

    public void hit() {
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.Play();
        playerAnimator.SetTrigger("Death");
        scoring.gameOver();
        Destroy(this.gameObject, 1);      
    }
}
