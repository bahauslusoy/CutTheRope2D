using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour
{
    public Rigidbody2D firstHook;
    public int connectionCount = 5;
    public GameObject[] connectionPool;
    public string hingeName;
    public Ball ball;

    void Start()
    {
        CreateRope();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CreateRope()
    {
        Rigidbody2D previousConnection = firstHook;

        for (int i = 0; i < connectionCount; i++)
        {
            connectionPool[i].SetActive(true);

            HingeJoint2D joint = connectionPool[i].GetComponent<HingeJoint2D>();
            joint.connectedBody = previousConnection;

            if (i < connectionCount - 1)
            {
                previousConnection = connectionPool[i].GetComponent<Rigidbody2D>();
            }
            else
            {
                ball.TieLastRope(connectionPool[i].GetComponent<Rigidbody2D>(), hingeName);
            }
        }
    }
}
