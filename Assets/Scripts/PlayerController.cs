using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D bird;
    public Text scoreUI;
    int score = 0;

    //True OR False value to chekc if bird is alive or not
    public bool isAlive;

    // Start is called before the first frame update
    void Start()
    {
        bird = GetComponent<Rigidbody2D>();
        // Set the alive to true
        isAlive = true;
    }

    // Update is called once per frame
    void Update()
    {
     if(Input.GetKeyDown(KeyCode.Space) && isAlive == true) 
     {
        bird.AddForce(new Vector2(0,1) * 200);
     }  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Points"))
        {
            // Increase score by 1
            score = score + 1;

            scoreUI.text = score.ToString();
        }
    }

    // Check when the player collides with something in the scene
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Set is Alive varible to false when a collision happens with the player
        isAlive = false;
    }
}
