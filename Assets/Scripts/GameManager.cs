using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int health = 3;
    public EnemySpawner enemySpawner;
    public GameObject gameOverText; 
    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            Debug.Log("cancelled invoke!");
            enemySpawner.CancelInvoke();
            gameOverText.SetActive(true); 
        }
    }

    public void IncrementScore()
    {
        Debug.Log("FUNCTION CALLED!");
        score = score + 10; 
    }

    public void DecrementHealth()
    {
        health--;  
    }

    public void IncrementHealth()
    {
        health++;  
    }
}
