using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthbarScript : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100f;
    PlayerIdle player;
    
    public void Start(){
        HealthBar = GetComponent<Image>();
        player = FindObjectOfType<PlayerIdle>();
    }
    private void Update(){
        CurrentHealth = player.Health;
        HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}
