using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawn : MonoBehaviour
{
    public Transform[] spawnPositions;
    public GameObject projectileObject;

    public float timeToSpawn;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        spawnObject(1);
        timer = timeToSpawn;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            spawnObject(Random.Range(0, spawnPositions.Length));
            timer = timeToSpawn;
        }
    }

    void spawnObject(int spawnLocation)
    {
        Instantiate(projectileObject, spawnPositions[spawnLocation].position, Quaternion.identity);
    }
}
