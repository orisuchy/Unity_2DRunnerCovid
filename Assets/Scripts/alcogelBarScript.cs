using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alcogelBarScript : MonoBehaviour
{
    private Image AlcogelBar;
    public float CurrentAlcogel;
    //private float MaxAlcogel = 100f;
    private float MaxAlcogel;
    private GameObject alcogelBarObject;

    alcogelShooter shooter;
    PlayerIdle player;

    // Start is called before the first frame update
    void Start()
    {
        AlcogelBar = GetComponent<Image>();
        alcogelBarObject = GameObject.FindGameObjectWithTag("AlcogelSlider");
        player = FindObjectOfType<PlayerIdle>();
        shooter = FindObjectOfType<alcogelShooter>();

        MaxAlcogel = 6f;
        
        //alcogelBarObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentAlcogel = shooter.gelTimer;
        AlcogelBar.fillAmount = CurrentAlcogel / MaxAlcogel;
    }
}
