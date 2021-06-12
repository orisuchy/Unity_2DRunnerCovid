using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public float Health = 100f;
    public int isShieldUp = 0;

    public Image[] shield;
    public Sprite fullShield;
    public Sprite emptyShield;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        normalRotation = Quaternion.Euler(0, 0, 0);
        downRotation = Quaternion.Euler(0, 0, -20);
        upRotation = Quaternion.Euler(0, 0, 20);
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
        for(int i=0; i<shield.Length; i++){
            if(i< isShieldUp){
                shield[i].enabled = true;
            }else {
                shield[i].enabled = false;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Border")
        {
            onBottomBorder = true;
        }
    }
    public void getHit(){
        if(isShieldUp > 0){
           isShieldUp -= 1; 
        }
        else{
            Health -= 25;
            if(Health <= 0){
                Destroy(this.gameObject);
            }
        }        
    }
    public void ShieldUP(){
        isShieldUp = 3;
        
    }
}
