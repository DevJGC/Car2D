using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    public GameObject[] spawnObjects;

    public float spawnTime;

    public float maxSpawn;

    void Start()
    {
        
    }

    void Update()
    {

        spawnTime -= Time.deltaTime;

        if (spawnTime <= 0)
        {
            int randomIndex = Random.Range(0, spawnObjects.Length);
            Instantiate(spawnObjects[randomIndex], transform.position, Quaternion.identity);
            spawnTime = Random.Range(maxSpawn, maxSpawn+2);
        }
        
    }


}
