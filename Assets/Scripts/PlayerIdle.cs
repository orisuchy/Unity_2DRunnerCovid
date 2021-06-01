using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdle : MonoBehaviour
{
    public float tapForce = 250;
    public float tiltSmooth = 2;
    public Vector3 startPos;
    private bool onBottomBorder;

    Rigidbody2D rb;
    Quaternion normalRotation;
    Quaternion downRotation;
    Quaternion upRotation;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        normalRotation = Quaternion.Euler(0, 0, 0);
        downRotation = Quaternion.Euler(0, 0, -35);
        upRotation = Quaternion.Euler(0, 0, 35);
        onBottomBorder = false;


}

// Update is called once per frame
void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onBottomBorder = false;
            transform.rotation = upRotation;
            rb.velocity = Vector3.zero;
            rb.AddForce(Vector2.up * tapForce, ForceMode2D.Force);
        }
        if (onBottomBorder)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, normalRotation, tiltSmooth * Time.deltaTime);

        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, downRotation, tiltSmooth * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Border")
        {
            onBottomBorder = true;
        }
    }
}
