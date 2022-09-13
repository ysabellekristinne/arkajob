using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int blocksPhase;

    public AudioSource blockSound;
    public AudioSource gameOverMusic;

    public GameObject gameOverScreen;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddBlock()
    {
        blocksPhase += 1;
    }

    public void DisBlock()
    {
        blocksPhase -= 1;
        blockSound.Play();

        if (blocksPhase == 0)
        {
            passPhase();
        }
    }

    public void passPhase()
    {
        if (SceneManager.GetActiveScene().buildIndex + 1 < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            SceneManager.LoadScene(4);
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0f;
        gameOverMusic.Play();

        gameOverScreen.SetActive(true);
    }
}
