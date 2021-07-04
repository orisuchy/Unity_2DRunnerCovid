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
    private float spawnTime;
    private float spawnTimeMaskShield;
    private float spawnTimeAlcogel;

    private float timeBetweenSpawn;
    private float MStimeBetweenSpawn;
    private float ALtimeBetweenSpawn;

    public float levelStartTime;
    public int levelNum;
    private float timeOnGame;


    void Start()
    {
        levelNum = 1;
        levelStartTime = Time.time;
        timeOnGame = 0;
        LevelChange();
        spawnTime = timeBetweenSpawn;
        spawnTimeMaskShield = MStimeBetweenSpawn;
        spawnTimeAlcogel = ALtimeBetweenSpawn;

    }
    // Update is called once per frame
    void Update()
    {
        timeOnGame = Time.time - levelStartTime;
        if (levelNum < 6)
            LevelChange();
        if (timeOnGame > spawnTime)
        {
            Spawn(obstacle);
            spawnTime = timeOnGame + timeBetweenSpawn;
        }
        if (timeOnGame > spawnTimeMaskShield)
        {
            Spawn(shieldMask);
            spawnTimeMaskShield = timeOnGame + MStimeBetweenSpawn;
        }

        if (timeOnGame > spawnTimeAlcogel)
        {
            Spawn(alcogel);
            spawnTimeAlcogel = timeOnGame + ALtimeBetweenSpawn;
        }

    }
    //void Update()
    //{
    //    if (levelNum < 5)
    //        LevelChange();
    //    if (Time.time > spawnTime)
    //    {
    //        Spawn(obstacle);
    //        spawnTime = Time.time + timeBetweenSpawn;
    //    }
    //    if(Time.time > spawnTimeMaskShield)
    //    {
    //        Spawn(shieldMask);
    //        spawnTimeMaskShield = Time.time + MStimeBetweenSpawn;
    //    }

    //    if (Time.time > spawnTimeAlcogel)
    //    {
    //        Spawn(alcogel);
    //        spawnTimeAlcogel = Time.time + ALtimeBetweenSpawn;
    //    }

    //}

    void Spawn(GameObject obj)
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obj, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void LevelChange()
    {
        if (timeOnGame <= 10f)
        {
            if (levelNum == 1)
            {
                timeBetweenSpawn = 1.3f;
                MStimeBetweenSpawn = 11f;
                ALtimeBetweenSpawn = 12f;
                levelNum++;
                Debug.Log($"timeOnGame: {timeOnGame}\nlevelNum: {levelNum}\nvirus time: {timeBetweenSpawn}\nmasktime: {MStimeBetweenSpawn}\nalcogel time: {ALtimeBetweenSpawn}\n");
            } 
        }
        else if (timeOnGame <= 30f)
        {
            if (levelNum == 2)
            {
                timeBetweenSpawn = 1f;
                MStimeBetweenSpawn = 4f;
                ALtimeBetweenSpawn = 5f;
                levelNum++;
                Debug.Log($"timeOnGame: {timeOnGame}\nlevelNum: {levelNum}\nvirus time: {timeBetweenSpawn}\nmasktime: {MStimeBetweenSpawn}\nalcogel time: {ALtimeBetweenSpawn}\n");
            }
        }
        else if (timeOnGame <= 45f)
        {
            if (levelNum == 3)
            {
                timeBetweenSpawn = 0.8f;
                MStimeBetweenSpawn = 5f;
                ALtimeBetweenSpawn = 6f;
                levelNum++;
                Debug.Log($"timeOnGame: {timeOnGame}\nlevelNum: {levelNum}\nvirus time: {timeBetweenSpawn}\nmasktime: {MStimeBetweenSpawn}\nalcogel time: {ALtimeBetweenSpawn}\n");
            }
        }
        else if (timeOnGame <= 60f)
        {
            if (levelNum == 3)
            {
                timeBetweenSpawn = 0.8f;
                MStimeBetweenSpawn = 6f;
                ALtimeBetweenSpawn = 7f;
                levelNum++;
                Debug.Log($"timeOnGame: {timeOnGame}\nlevelNum: {levelNum}\nvirus time: {timeBetweenSpawn}\nmasktime: {MStimeBetweenSpawn}\nalcogel time: {ALtimeBetweenSpawn}\n");
            }
        }
        else
        {
            timeBetweenSpawn = 0.6f;
            MStimeBetweenSpawn = 6f;
            ALtimeBetweenSpawn = 7f;
            levelNum++;
            Debug.Log($"timeOnGame: {timeOnGame}\nlevelNum: {levelNum}\nvirus time: {timeBetweenSpawn}\nmasktime: {MStimeBetweenSpawn}\nalcogel time: {ALtimeBetweenSpawn}\n");
        }

    }
}
