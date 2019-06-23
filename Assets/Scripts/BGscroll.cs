using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{
    public int TargetScore;
    public float BckgrndSpd;
    public Renderer BckgrndRend;

    void Start()
    {
        TargetScore = 250;
        BckgrndSpd = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //scrolls the background image in the mesh renderer infinitely on the y axis at the speed of the float
        BckgrndRend.material.mainTextureOffset += new Vector2(0f,BckgrndSpd * Time.deltaTime);

        if (TargetScore >=250 && TargetScore <-1000)
        {
            BckgrndSpd += 0.1f;
            TargetScore += 250;
        }
    }

}
