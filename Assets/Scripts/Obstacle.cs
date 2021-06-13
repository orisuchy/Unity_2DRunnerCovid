﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private bool hitFlag = true; // needed to prevent the enemy to hit the player twice in one enounter.
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Shooter")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player" && hitFlag) 
        {
            hitFlag = false;
            //Destroy(player.gameObject);
            Destroy(this.gameObject);
            PlayerIdle other = (PlayerIdle) player.GetComponent(typeof(PlayerIdle));
            other.getHit();            
            return;
        }
    }
}
