using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    public Text scoreText;
    private float score;
    public GameObject scoreobj;
    private highscore_script other;

    void Start()
    {

        other = (highscore_script)scoreobj.GetComponent(typeof(highscore_script));
        
    }

 
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString();
            //highscore_script other = (highscore_script) scoreobj.GetComponent(typeof(highscore_script));
        }
    }

   public void updateScore()
    {
        other.updateScore((int)score);
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        scoreobj = GameObject.FindGameObjectWithTag("ScoreObject");
    }
}
