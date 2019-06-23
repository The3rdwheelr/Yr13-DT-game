using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGscroll : MonoBehaviour
{
    public int targetScore;
    public float BckgrndSpd;
    public Renderer BckgrndRend;

    void Start()
    {
        targetScore = 250;
        BckgrndSpd = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //scrolls the background image in the mesh renderer infinitely on the y axis at the speed of the float
        BckgrndRend.material.mainTextureOffset += new Vector2(0f,BckgrndSpd * Time.deltaTime);

        if (PlayerManager.playerScore >= targetScore && targetScore <= 1000)
        {
            BckgrndSpd += 0.0625f;
            targetScore += 250;
        }
    }

}
