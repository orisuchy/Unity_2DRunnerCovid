using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alcogelToCollect : MonoBehaviour
{
    private GameObject player;
    private GameObject shooter;
    
    private bool shooterOn = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //shooter = GameObject.FindGameObjectWithTag("Shooter");
        shooter = player.transform.Find("Alcogel").gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player" && !shooterOn)
        {

            Destroy(this.gameObject);
            shooterOn = true;
            shooter.SetActive(true);
            return;
        }
    }
}
