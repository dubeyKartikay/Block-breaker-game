using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] PaddleMovement paddle1;
    [SerializeField] Vector3 startingOffset = new Vector3(0, 1, 0);
    [SerializeField] Vector2 staringVelocity = new Vector2(0,1);
    [SerializeField] AudioClip[] ballAudioClips;
    
    //Cached component references
    Rigidbody2D rb;
    AudioSource audioSource;

    bool started;
    void Start()
    {
        transform.position = paddle1.transform.position + startingOffset;
        started = false;
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") || Input.GetMouseButtonDown(0))
        {
            started = true;
            rb.velocity = staringVelocity;

        }
        if (!started)
        {
            transform.position = paddle1.transform.position + startingOffset;

        }

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (started)
        {
            AudioClip clip = ballAudioClips[UnityEngine.Random.Range(0, ballAudioClips.Length)];
            audioSource.PlayOneShot(clip);
        }
    }   
}
