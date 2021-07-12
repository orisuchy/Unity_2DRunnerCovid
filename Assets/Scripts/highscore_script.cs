using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore_script : MonoBehaviour
{
  public Text score;
  public int scroe_val;
void Start()
    {
        //score.text = scroe_val.ToString();
    }
 public void updateScore(int curr_score){
      if(curr_score > scroe_val){
          scroe_val=curr_score;
          score.text = scroe_val.ToString();
      }
  }
}
