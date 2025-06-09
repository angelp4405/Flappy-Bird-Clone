using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    //Creating a varible to store the PlayerController script
    PlayerController playerControllerScript;
    public float speed;
    // Start is called before the first frame update
    void Awake()
    {
        // Find the player controller script when the game starts
        playerControllerScript = GameObject.Find("Red_Bird_0").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.isAlive == true)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            speed = 0;
        }

        //Move pipes left
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}
