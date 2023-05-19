using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public float speed = 5.0f; // velocidade da bola
    public GameObject objectToInstantiate; // objeto a ser instanciado

    private bool moveRight = true; // vari�vel para controlar a dire��o da movimenta��o da bola
    private float bound = 4;
    private float ballInTable;


    public BallCounter ballCounter;
    private void Start()
    {
        ballCounter = GameObject.FindObjectOfType<BallCounter>();
    }
    void Update()
    {
      
        // movimenta a bola
        if (moveRight)
        {
            transform.Translate(new Vector3(0, 0, speed) * Time.deltaTime);
        }
        else
        {
            transform.Translate(new Vector3(0, 0, -speed) * Time.deltaTime);
        }

        // verifica se a bola chegou ao limite da tela e muda a dire��o da movimenta��o
        if (transform.position.z > bound)
        {
            moveRight = false;
        }
        else if (transform.position.z < -bound)
        {
            moveRight = true;
        }

        // verifica se o bot�o espa�o foi pressionado e instancia o objeto
        if (Input.GetKeyDown(KeyCode.Space) && ballCounter.balls > 0)
        {
             // gera uma cor aleat�ria
            Color randomColor = new Color(Random.value, Random.value, Random.value);

            // cria o objeto instanciado
            GameObject newObject = Instantiate(objectToInstantiate, transform.position, Quaternion.identity);

            // muda a cor do objeto instanciado para a cor aleat�ria
            newObject.GetComponent<Renderer>().material.color = randomColor;
            ballCounter.SendMessage("UpdateBallInTableCount",1);
            ballCounter.SendMessage("UpdateObjectCount", -1);
        }
    }
}
