using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    float xinput;
    public float moveSpeed;
    Vector2 newPosition;
    public float xPositionLimit; 

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        // -1 to + 1
        xinput = Input.GetAxis("Horizontal");

        newPosition = transform.position;
        newPosition.x += xinput * moveSpeed;
        newPosition.x = Mathf.Clamp(newPosition.x, -xPositionLimit, xPositionLimit);
        rb.MovePosition(newPosition);

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "rabbit")
        {
            Destroy(col.gameObject);
        }
    }

}
