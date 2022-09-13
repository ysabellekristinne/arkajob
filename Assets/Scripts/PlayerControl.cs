using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float playerSpeed;

    public float xMin;
    public float xMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, xMin, xMax), transform.position.y);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * playerSpeed * Time.deltaTime);
        }
    }
}
