using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float fallSpeed = 8.0f;

    public BoxCollider2D playerCol;
    public BoxCollider2D projCol;

    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.playerHealth--;
        Destroy(gameObject);
        Debug.Log(PlayerManager.playerHealth);
    }

    void checkForOutOfBounds()
    {
        if(transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
