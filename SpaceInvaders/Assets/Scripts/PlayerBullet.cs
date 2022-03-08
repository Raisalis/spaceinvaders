using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerBullet : MonoBehaviour
{
    private Rigidbody2D myRigidbody2D;
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        Fire();
    }

    // Update is called once per frame
    public void Fire()
    {
        myRigidbody2D.velocity = Vector2.up * speed; 
    }

    public void OnCollisionEnter2D(Collision2D col) {
        if(col.gameObject.tag == "Enemy" || col.gameObject.tag == "Shooter") {
            col.gameObject.GetComponent<Enemy>().hit();
            Destroy(this.gameObject);
        } else if(col.gameObject.tag == "Shield") {
            col.gameObject.GetComponent<ShieldChild>().hit();
            Destroy(this.gameObject);
        }
    }
}
