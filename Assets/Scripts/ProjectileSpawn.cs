using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject[] objectTypes; //array for the types of objects that could spawn
    public Transform[] spawnPositions; //array for the spawnpoints
    public float timeToSpawn; // reference for the spawn delay of obstacles
    float spawnTimer;
    int targetScore;

    float spawnRandomizer;

    private void Start()
    {
        spawnTimer = timeToSpawn; //the delay between object spawns
        targetScore = 250;
        timeToSpawn = 0.2f;

    }
    private void Update()
    {

        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) { spawnObject(); spawnTimer = timeToSpawn; } // if spawn timer is 0, spawn a object from the commands below

        if (PlayerManager.playerScore >= targetScore && targetScore <= 1000)
        {
            timeToSpawn -= 0.005f;
            targetScore += 250;
        }
    }   

    void spawnObject()
    {
        int spawnPos = Random.Range(0, spawnPositions.Length); //sets the spawn positons to the spawnpoints
        spawnRandomizer = Random.Range(0, 100); //determines out of a 100 the probability of spawning one of the below
        if (spawnRandomizer < 5) //spawn a heart with a 5% chance
        {
            Instantiate(objectTypes[0], spawnPositions[spawnPos].position, Quaternion.identity);
        }
        else if (spawnRandomizer < 25) //spawn a moneybag with a 20% chance
        {
            Instantiate(objectTypes[1], spawnPositions[spawnPos].position, Quaternion.identity);
        }
        else if (spawnRandomizer < 67.5) //spawn a cat with a 37.5% chance
        {
            Instantiate(objectTypes[2], spawnPositions[spawnPos].position, Quaternion.identity);
        }
        else //spawn a dog with a 37.5% chance (for variety)
        {
            Instantiate(objectTypes[3], spawnPositions[spawnPos].position, Quaternion.identity);
        }
    }
}