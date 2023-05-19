using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteBall : MonoBehaviour
{
    // public GameObject ballCounter;
    BallCounter ballCounter;
    void Start()
    {
        ballCounter = GameObject.FindObjectOfType<BallCounter>();
    }
    void OnTriggerEnter(Collider other)
    {
        // verifica se o objeto que tocou o collider deve ser deletado
        if (other.gameObject.CompareTag("Ball"))
        {
            // deleta o objeto
            ballCounter.UpdateBallInTableCount(-1);
            Destroy(other.gameObject);
            // ballCounter.SendMessage("UpdateObjectCount", -1);               
        }
    }
}
