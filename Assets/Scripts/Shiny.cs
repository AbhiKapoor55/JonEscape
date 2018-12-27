using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Shiny : MonoBehaviour
{
    public GameManager gm;
    public Text scoreText; 
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>(); 
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "rabbit")
        {
            Debug.Log("+10 points?");
            gm.IncrementScore();
            scoreText.text = "Score: " + gm.score.ToString(); 
        }

    }
}
