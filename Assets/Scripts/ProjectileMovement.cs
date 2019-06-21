using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    //sets the public class float to a changeable value
    public float fallSpeed = 8.0f;

    void Update()
    {        
        // makes the obstacle fall down towards the player and speed is adjustable by fallspd float
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime, Space.World);
        checkForOutOfBounds();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerManager.playerHealth--; //decrease player health by 1
        Destroy(gameObject); // destroys the obstacle afterwards
    }

    void checkForOutOfBounds() //checks to see if object is out of bounds
    {
        if(transform.position.y < -12)
        {
            Destroy(gameObject);
        }
    }
}
