using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public GameObject[] objectTypes;
    public Transform[] spawnPositions;

    public float timeToSpawn;
    float spawnTimer;

    float spawnRandomizer;

    private void Start()
    {
        spawnTimer = timeToSpawn;
    }
    private void Update()
    {
        
        spawnTimer -= Time.deltaTime;
        if (spawnTimer  <= 0) { spawnObject(); spawnTimer = timeToSpawn; }
    }

    void spawnObject()
    {
        int spawnPos = Random.Range(0, spawnPositions.Length);
        spawnRandomizer = Random.Range(0, 100);
        if (spawnRandomizer < 5)
        {
            Instantiate(objectTypes[0], spawnPositions[spawnPos].position, Quaternion.identity);
        }
        else if (spawnRandomizer < 20)
        {
            Instantiate(objectTypes[1], spawnPositions[spawnPos].position, Quaternion.identity);
        }
        else
        {
            Instantiate(objectTypes[2], spawnPositions[spawnPos].position, Quaternion.identity);
        }
    }
}
