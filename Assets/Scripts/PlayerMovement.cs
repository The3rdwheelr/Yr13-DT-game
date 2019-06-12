using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    float turnTimer;
    public int lanesFromCentre;
    float laneBorderMin;
    float laneBorderMax;

    private void Start()
    {
        laneBorderMin = transform.position.x - lanesFromCentre;
        laneBorderMax = transform.position.x + lanesFromCentre;
        turnTimer = 0.5f;
    }

    public void Update()
    {
        // sets the player to move left/right on key press
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > laneBorderMin)
        {
            animator.SetBool("LeftKeypress", true);
            animator.SetBool("RightKeypress", false);
            transform.position += Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < laneBorderMax)
        {
            animator.SetBool("RightKeypress", true);
            animator.SetBool("LeftKeypress", false);
            transform.position += Vector3.right;
        }

        if (turnTimer > 0)
        {
            turnTimer -= Time.deltaTime;
        }
        else
        {
            animator.SetBool("LeftKeypress", false);
            animator.SetBool("RightKeypress", false);
            turnTimer = 0.5f;
        }
    }
}
