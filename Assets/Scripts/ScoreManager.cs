using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    private float score;
    public GameObject scoreobj;

    void Start()
    {
        scoreobj = GameObject.FindGameObjectWithTag("ScoreObject");
    }

    
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            highscore_script other = (highscore_script) scoreobj.GetComponent(typeof(highscore_script));
            other.updateScore((int)score);
        }
    }
}
