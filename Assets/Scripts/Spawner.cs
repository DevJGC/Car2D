using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Prefabs del Spawner
    public GameObject[] spawnObjects;
    // Tiempo para el siguiente spawn
    public float spawnTime;
    // Tiempo maximo del spawn
    public float maxSpawn;

    // No utilizado por el momento
    void Start()
    {
        
    }

    void Update()
    {
        // Resta tiempo al Spawner
        spawnTime -= Time.deltaTime;

        // Si el tiempo es menor a 0
        if (spawnTime <= 0)
        {   
            // Genera un numero aleatorio y lo instancia
            int randomIndex = Random.Range(0, spawnObjects.Length);
            Instantiate(spawnObjects[randomIndex], transform.position, Quaternion.identity);
            spawnTime = Random.Range(maxSpawn, maxSpawn+2);
        } 
    }
}
