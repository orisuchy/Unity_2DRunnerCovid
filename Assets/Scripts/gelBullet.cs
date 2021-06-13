using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class gelBullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;   
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Virus")
        {
            Destroy(col);
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Border")
        {
            Destroy(gameObject);
        }
    }
}
