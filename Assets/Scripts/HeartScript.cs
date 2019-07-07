using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    float fallSpeed = 8.0f;
    int targetScore;

    private void Start()
    {
        targetScore = 250;
        fallSpeed = 8f;
    }

    void Update()
    {
        // for every 250 score te player obtains (capped at 1000), increase the heart fall speed
        if (PlayerManager.playerScore >= targetScore && targetScore <= 1000)
        {
            fallSpeed += 1f;
            targetScore += 250;
        }

        // when instantiated, start falling down towards player at speed set by the public float
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // if player is not on max lives, add one life
        if (PlayerManager.playerHealth < PlayerManager.playerMaxHealth)
        {
            PlayerManager.playerHealth++;
        }
        else
        {
            // if player is on max lives, get 25 score points
            PlayerManager.playerScore += 25;
        }
        Destroy(gameObject);
    }

    void checkForOutOfBounds() //checks for out of bounds
    {
        // destroy the object if it the transform is more than -12 on y axis
        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
