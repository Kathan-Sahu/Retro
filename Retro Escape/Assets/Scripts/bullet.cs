using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject gameOverMenu;
    public float speed;
    
    private int count;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, 0.83f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
