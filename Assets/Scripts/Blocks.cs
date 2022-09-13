using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<GameManager>().AddBlock();
    }

    void OnCollisionEnter2D(Collision2D collisionInfo) 
    {
        if(collisionInfo.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().DisBlock();
            Destroy(this.gameObject);
        }
    }
}
