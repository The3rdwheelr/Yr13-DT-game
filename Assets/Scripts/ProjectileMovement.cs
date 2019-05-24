using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    public float speed;
    Vector3 pos;
    Vector3 newPos;
    
    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        newPos = pos + (Vector3.down * speed);
        transform.position = newPos;
    }
}
