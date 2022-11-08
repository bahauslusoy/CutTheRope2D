using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball ballInstance;
    public float distanceBalltoRope = 0.2f;
    public Dictionary<string, HingeJoint2D> controlHinge = new Dictionary<string, HingeJoint2D>();

    private void Awake()
    {
        ballInstance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TieLastRope(Rigidbody2D lastRope, string hingeName)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        controlHinge.Add(hingeName, joint);
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastRope;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceBalltoRope);

    }
}
