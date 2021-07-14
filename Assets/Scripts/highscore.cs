using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour
{
    public Text score;
    public int scroe_val = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = scroe_val.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void updateScore(int curr_score){
        if(curr_score > scroe_val){
            scroe_val=curr_score;
            score.text = scroe_val.ToString();
        }
    }
    public void Awake()
    {
        DontDestroyOnLoad(this);
    }
}
