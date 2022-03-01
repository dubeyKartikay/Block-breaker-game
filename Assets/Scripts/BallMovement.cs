using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] PaddleMovement paddle1;
    [SerializeField] Vector3 startingOffset = new Vector3(0, 1, 0);
    [SerializeField] Vector2 staringVelocity = new Vector2(0,1);
    
    Rigidbody2D rb;

    bool started;
    void Start()
    {
        transform.position = paddle1.transform.position + startingOffset;
        started = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            started = true;
            rb.velocity = staringVelocity;

        }
        if (!started)
        {
            transform.position = paddle1.transform.position + startingOffset;

        }

        
    }
}
