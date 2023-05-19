using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    BallCounter ballCounter;
    Points points;
    void Start()
    {
        ballCounter = GameObject.FindObjectOfType<BallCounter>();
        points = GameObject.FindObjectOfType<Points>();

    }
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Scene")
        {
            if (ballCounter.balls <= 0 && ballCounter.ballsInTable <= 0)
            {
                GameOver();
            }
        
        }
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Scene", LoadSceneMode.Single);
    }
    public void GameOver()
    {
        SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
    }
  
    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("saiu");
    }

}
