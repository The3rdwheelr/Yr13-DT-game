using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{
    public float BckgrndSpd;
    public Renderer BckgrndRend;

    // Update is called once per frame
    void Update()
    {
        //scrolls the background image in the mesh renderer infinitely on the y axis at the speed of the float
        BckgrndRend.material.mainTextureOffset += new Vector2(0f,BckgrndSpd * Time.deltaTime);
    }
}
