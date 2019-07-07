using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    // sets the public class float to a changeable value
    float fallSpeed = 8.0f;
    int targetScore;

    private void Start()
    {
        targetScore = 250;
        fallSpeed = 8.0f;
    }
    void Update()
    {        
        // makes the obstacle fall down towards the player and speed is adjustable by fallspd float
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();

        // for every 250 score te player obtains (capped at 1000), increase the enemy fall speed
        if (PlayerManager.playerScore >= targetScore && targetScore <= 1000)
        {
            fallSpeed += 1f;
            targetScore += 250;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.playerHealth--; // decrease player health by 1
        PlayerManager.playerScore--; // decrease player score by 1
        Destroy(gameObject); // destroys the obstacle afterwards
    }

    void checkForOutOfBounds() // checks to see if object is out of bounds
    {
        if(transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
