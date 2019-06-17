using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartScript : MonoBehaviour
{
    public float fallSpeed = 8.0f;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (PlayerManager.playerHealth < PlayerManager.playerMaxHealth)
        {
            PlayerManager.playerHealth++;
        }
        else
        {
            PlayerManager.playerScore += 10;
        }
        Destroy(gameObject);
    }

    void checkForOutOfBounds()
    {
        if (transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
