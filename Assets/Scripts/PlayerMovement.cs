using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int lanesFromCentre;
    public void Update()
    {
        // sets the player to move left/right on key press
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -lanesFromCentre)
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < lanesFromCentre)
        {
            transform.position += Vector3.right;
        }
    }
}
