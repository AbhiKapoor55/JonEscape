using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class cherry : MonoBehaviour
{
    public GameManager gm;
    public Text healthText; 
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
            if(gm.health < 3)
            {
                gm.IncrementHealth();
                healthText.text = "Health: " + gm.health;
            }
        }
    }
}
