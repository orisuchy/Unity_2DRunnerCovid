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

    PlayerIdle player;

    // Start is called before the first frame update
    void Start()
    {
        AlcogelBar = GetComponent<Image>();
        alcogelBarObject = GameObject.FindGameObjectWithTag("AlcogelSlider");
        player = FindObjectOfType<PlayerIdle>();
        MaxAlcogel = 6f;
        //alcogelBarObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CurrentAlcogel = FindObjectOfType<alcogelShooter>().gelTimer;
        if (CurrentAlcogel >= 0)
        {
            //alcogelBarObject.SetActive(true);
            AlcogelBar.fillAmount = CurrentAlcogel / MaxAlcogel;
        }
        //else
        //    alcogelBarObject.SetActive(false);
    }
}
