using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    Quaternion normalRotation;
    Quaternion downRotation;
    Quaternion upRotation;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        normalRotation = Quaternion.Euler(0, 0, 0);
        downRotation = Quaternion.Euler(0, 0, -20);
        upRotation = Quaternion.Euler(0, 0, 20);
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
        if (directionY > 0)
        {
            transform.rotation = upRotation;
        }
        else if (directionY < 0)
        {
            transform.rotation = downRotation;
        }
        else
        {
            transform.rotation = normalRotation;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
