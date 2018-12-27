using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public GameManager gm;
    public Text healthText; 
    // Start is called before the first frame update
    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gm.DecrementHealth();
            healthText.text = "Health: "+gm.health.ToString();
            Debug.Log("Health is now: "+gm.health);
        }

    }
}
