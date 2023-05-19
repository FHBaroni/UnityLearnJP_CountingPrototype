using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    BallCounter ballCounter;
   private GameObject MoreBallsTextPrefab;
   
    //public bool winCondition = false;
    void Start()
    {
        ballCounter = GameObject.FindObjectOfType<BallCounter>();
       // MoreBalls("3");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Point3"))
        {
            ballCounter.UpdateObjectCount(1);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            //   MoreBalls("1");
            ballCounter.point1 = true; 
        }
        else if ( other.gameObject.CompareTag("Point32"))
        {
            ballCounter.UpdateObjectCount(1);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            //   MoreBalls("1");
            ballCounter.point2 = true;

        }
        else if (other.gameObject.CompareTag("Point5") )
        {
            ballCounter.UpdateObjectCount(2);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            // MoreBalls("2");
            ballCounter.point3 = true;

        }
        else if ( other.gameObject.CompareTag("Point52"))
        {
            ballCounter.UpdateObjectCount(2);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            // MoreBalls("2");
            ballCounter.point4 = true;

        }
        else if (other.gameObject.CompareTag("Point7") )
        {
            ballCounter.UpdateObjectCount(3);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            // MoreBalls("3");
            ballCounter.point5 = true;

        }
        else if ( other.gameObject.CompareTag("Point72"))
        {
            ballCounter.UpdateObjectCount(3);
            Invoke("UpadteBallInTableAfterDelay", 1f);
            // MoreBalls("3");
            ballCounter.point6 = true;

        }
        else
        {
            Invoke("UpadteBallInTableAfterDelay", 1f);
        }
        
    }

    void UpadteBallInTableAfterDelay()
    {
        ballCounter.SendMessage("UpdateBallInTableCount", -1);
    }
    //public void MoreBalls(string balls)
    //{       
    //        GameObject prefab = Instantiate(MoreBallsTextPrefab, transform.position, Quaternion.identity);
    //        prefab.GetComponentInChildren<Text>().text = balls;        
    //}

}
