using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldChild : MonoBehaviour
{

    public SpriteRenderer spriterender;
    public Sprite sprite2;
    private int life;

    // Start is called before the first frame update
    void Start()
    {
        life = 2;
        spriterender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void hit() {
        life--;
        if(life > 0) {
            spriterender.sprite = sprite2;
        }
        else {
            Destroy(this.gameObject);
        }
    }

}
