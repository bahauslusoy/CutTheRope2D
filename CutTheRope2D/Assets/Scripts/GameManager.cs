using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private int totalBallsCount;
    [SerializeField] private int targetObjectsCount;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()

    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null)
            {
                if (hit.collider.CompareTag("Center1"))
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);
                    Ball.ballInstance.controlHinge["Center1"].enabled = false;
                }
                else if (hit.collider.CompareTag("Center2"))
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);
                    Ball.ballInstance.controlHinge["Center2"].enabled = false;
                }

                else if (hit.collider.CompareTag("Center3"))
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);
                    Ball.ballInstance.controlHinge["Center3"].enabled = false;
                }

                else if (hit.collider.CompareTag("Center4"))
                {
                    //Destroy(hit.collider.gameObject);
                    hit.collider.gameObject.SetActive(false);
                    Ball.ballInstance.controlHinge["Center4"].enabled = false;
                }
            }
        }

    }

    public void FallBall()
    {
        totalBallsCount--;
        if (totalBallsCount == 0)
        {
            if (targetObjectsCount > 0)
            {
                // Lose
            }
            else if (targetObjectsCount == 0)
            {
                //win
            }
        }
        else
        {
            if (targetObjectsCount == 0)
            {
                //win
            }
        }
    }
    public void FallTargetObject()
    {
        targetObjectsCount--;
        if (totalBallsCount == 0 && targetObjectsCount == 0)
        {
            //win

        }
        else if (totalBallsCount == 0 && targetObjectsCount > 0)
        {
            //lose
        }

    }

}


