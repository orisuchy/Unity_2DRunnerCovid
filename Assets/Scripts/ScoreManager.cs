using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{

    
    private float score;
    static public float highscore = 0;
    public Text scoreText; 
    public Text highScoreText;
    private Scene currentScene;
    private string sceneName;
    

    void Start()
    {
               
        currentScene = SceneManager.GetActiveScene ();        
        sceneName = currentScene.name; 
        if (sceneName == "HighScore") 
        {
             highScoreText.text =  ((int)highscore).ToString();
        }
        
        
    }

 
    // Update is called once per frame
    void Update()
    {
        if(sceneName == "idleOneButton"){        
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                score += 1 * Time.deltaTime;
                if(scoreText != null){
                    scoreText.text = ((int)score).ToString();
                }                
                if(score>highscore){
                    highscore=score;                
                }            
            }
        }
    }

   
}
