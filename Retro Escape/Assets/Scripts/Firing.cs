using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Firing : MonoBehaviour
{
    public Transform firepoint;
    public GameObject bullet;
    
    public float startTimeBetween;
    
    
    float timeBetween;
    
    // Start is called before the first frame update
    void Start()
    {
        timeBetween = startTimeBetween;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBetween <= 0)
        {
            Instantiate(bullet, firepoint.position, firepoint.rotation);
            timeBetween = startTimeBetween;
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }

    
}
