using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject shieldMask;
    public GameObject alcogel;

    public float maxX;
    public float minX;
    public float maxY;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    public float MStimeBetweenSpawn;
    public float ALtimeBetweenSpawn;
    private float spawnTimeMaskShield;
    private float spawnTimeAlcogel;



    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn(obstacle);
            spawnTime = Time.time + timeBetweenSpawn;
        }
        if(Time.time > spawnTimeMaskShield)
        {
            Spawn(shieldMask);
            spawnTimeMaskShield = Time.time + MStimeBetweenSpawn;
        }

        if (Time.time > spawnTimeAlcogel)
        {
            Spawn(alcogel);
            spawnTimeAlcogel = Time.time + ALtimeBetweenSpawn;
        }
    }

    void Spawn(GameObject obj)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obj, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
