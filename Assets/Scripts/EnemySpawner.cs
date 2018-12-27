using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public GameObject shiny;
    public GameObject cherry;  
    public float xPositionLimit;
    public float spawnRate;  
    // Start is called before the first frame update
    void Start()
    {
        StartSpawning();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnSpike()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);
        Instantiate(enemy, spawnPosition, Quaternion.identity);

        float randomSpawn = Random.Range(0,7);
        if (randomSpawn < 3)
            SpawnShiny();
        else if (randomSpawn >= 6)
            SpawnCherry(); 
    }

    void SpawnCherry()
    {
        float randomX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 cherrySpawn = new Vector2(randomX, transform.position.y);
        Instantiate(cherry, cherrySpawn, Quaternion.identity); 
    }

    void SpawnShiny()
    {
        float randomShinyX = Random.Range(-xPositionLimit, xPositionLimit);
        Vector2 spawnPositionShiny = new Vector2(randomShinyX, transform.position.y);
        Instantiate(shiny, spawnPositionShiny, Quaternion.identity);
    }

    void StartSpawning()
    {
        InvokeRepeating("SpawnSpike", 1f, spawnRate);
    }

    public void StopSpawning()
    {
        CancelInvoke("SpawnSpike"); 
    }

}
