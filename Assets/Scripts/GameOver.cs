using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Ball"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
