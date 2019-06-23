using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldBagScript : MonoBehaviour
{
    //sets the float speed that determines how fast the object falls
    float fallSpeed = 8.0f;
    int targetScore;

    private void Start()
    {
        targetScore = 250;
        fallSpeed = 8f;
    }

    void Update()
    {
        if (PlayerManager.playerScore >= targetScore && targetScore <= 1000)
        {
            fallSpeed += 1f;
            targetScore += 250;
        }

        //when instantiated, start falling down towards player at speed set by the public float
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //when collected, gives player 10 score points
        PlayerManager.playerScore += 10;
        Debug.Log(PlayerManager.playerScore);
        Destroy(gameObject);
    }

    void checkForOutOfBounds()
    {
        //destroys object if it is out of bounds
        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
