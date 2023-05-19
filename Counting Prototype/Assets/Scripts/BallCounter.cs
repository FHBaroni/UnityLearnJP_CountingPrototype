using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallCounter : MonoBehaviour
{
    public Text counterText; // componente Text que exibe a contagem
    public int balls = 5; // contagem inicial de objetos
    public int ballsInTable = 0; // contagem inicial de objetos

    public bool point1 = false;
    public bool point2 = false;
    public bool point3 = false;
    public bool point4 = false;
    public bool point5 = false;
    public bool point6 = false;

    void Start()
    {
        // atualiza o texto inicial com a contagem inicial
        counterText.text = "Balls: " + balls;
    }
    private void Update()
    {
        if (point1 && point2 && point3 && point4 && point5 && point6)
        {
            Win();
            //winCondition = true;
        }
    }
    public void UpdateObjectCount(int increment)
    {
        // incrementa a contagem com o valor recebido e atualiza o texto
        balls += increment;
        counterText.text = "Balls: " + balls;
    }

    public void UpdateBallInTableCount(int increment)
    {
        // incrementa/decrementa a contagem com o valor recebido
        ballsInTable += increment;

    }
    public void Win()
    {
        SceneManager.LoadScene("Win", LoadSceneMode.Single);
    }
}

