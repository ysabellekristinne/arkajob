using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float ballSpeed;

    public Rigidbody2D oRigidbody2D;
    public AudioSource ballSound;

    public bool gameStarted;

    // Start is called before the first frame update
    void Start()
    {
        gameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted == false)
        {
            if(Input.GetKeyDown(KeyCode.Space)) 
            {
                MoveBall();
                gameStarted = true;
            }
        }
    }

    private void MoveBall() 
    {
        oRigidbody2D.velocity = Vector2.up * ballSpeed;
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) 
    {
        ballSound.Play();
    }
}
