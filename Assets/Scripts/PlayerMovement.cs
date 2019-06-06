using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int lanesFromCentre;
    float laneBorderMin;
    float laneBorderMax;

    private void Start()
    {
        laneBorderMin = transform.position.x - lanesFromCentre;
        laneBorderMax = transform.position.x + lanesFromCentre;
    }

    public void Update()
    {
        // sets the player to move left/right on key press
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > laneBorderMin)
        {
            transform.position += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < laneBorderMax)
        {
            transform.position += Vector3.right;
        }
    }
}
