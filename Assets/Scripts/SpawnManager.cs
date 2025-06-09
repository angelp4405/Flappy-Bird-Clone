using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject pipePrefab;
    float randomHeight = 0.5f;
    PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipes", 1.0f, 4.0f);
        // Find the player controller script when the game Starts
        playerControllerScript = GameObject.Find("Red_Bird_0").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerControllerScript.isAlive == false)
        {
            // Stop Spawning in new pipes
            CancelInvoke();
        }
    }

    void SpawnPipes()
    {
        Instantiate(pipePrefab, new Vector2(2, Random.Range(-randomHeight, randomHeight)), Quaternion.identity);
    }
}
