using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeManager : MonoBehaviour
{
    public Rigidbody2D firstHook;
    public int connectionCount = 5;
    public GameObject connectionPrefab;

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
            GameObject connection = Instantiate(connectionPrefab, transform);
            HingeJoint2D joint = connection.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousConnection;

            if (i < connectionCount - 1)
            {
                previousConnection = connection.GetComponent<Rigidbody2D>();
            }
            else
            {
                Ball.ballInstance.TieLastRope(connection.GetComponent<Rigidbody2D>());
            }
        }
    }
}
