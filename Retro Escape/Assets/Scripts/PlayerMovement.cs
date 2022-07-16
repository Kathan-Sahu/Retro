using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject gameOverMenu;
    public GameObject heart;
    public GameObject heart1;
    
    private Rigidbody2D myrigidbody;
    public float movementSpeed;
    public int health;
    public float jumpForce;
    private bool isJumping;
   
    // Start is called before the first frame update
    void Start()
    {
       
        myrigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * movementSpeed;

        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            myrigidbody.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isJumping = true;
        }
        
       

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            isJumping = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("is triggered");
        if (other.gameObject.CompareTag("bullets"))
        {
            health -= 10;  
            if( health <= 20)
            {
                heart.SetActive(false);
                
            }
            if (health <= 10)
            {
                heart1.SetActive(false);
               
            }
            if (health <= 0)
            {
                gameOverMenu.SetActive(true);
            }
        }
    }

}
