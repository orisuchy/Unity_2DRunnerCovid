using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class alcogelShooter : MonoBehaviour
{

    public float fireRate = 0;
    public LayerMask notToHit;
    public Transform firePoint;
    public GameObject gelPrefab;
    public Text gelTimerText;
    public float gelTimer;

    bool alcogelOn = false;
    float timeToFire = 0;
    


    void Start()
    {
        gameObject.SetActive(false);
        gelTimer = 10;

    }

    // Update is called once per frame
    void Update()
    {
        if (gelTimer > 0)
        {
            Shoot();
            //if (alcogelOn && Time.time > timeToFire)
            //{
            //    timeToFire = Time.time + 1 / fireRate;
            //    Shoot();
            //}
            gelTimer -= 1 * Time.deltaTime;
            gelTimerText.text = ((int)gelTimer).ToString();
        }
        if (gelTimer == 0)
        {
            gameObject.SetActive(false);
        }
    }

    void Shoot()
    {
        firePoint.position = new Vector3(firePoint.position.x, firePoint.position.y, -10);
        Instantiate(gelPrefab, firePoint.position, firePoint.rotation);
        //Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
    }
}
