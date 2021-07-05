using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    public ParticleSystem virusExplosion;
    public ParticleSystem virusRedExplosion;

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
            Instantiate(virusExplosion, transform.position, transform.rotation);
            virusExplosion.Play();
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player" && hitFlag) 
        {
            hitFlag = false;
            //Destroy(player.gameObject);
            
            PlayerIdle other = (PlayerIdle) player.GetComponent(typeof(PlayerIdle));
            other.getHit();
            other.playCough();
            Instantiate(virusRedExplosion, transform.position, transform.rotation);
            virusRedExplosion.Play();
            Destroy(this.gameObject);
            return;
        }
    }
}
