using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball ballInstance;
    public float distanceBalltoRope = 0.2f;

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

    public void TieLastRope(Rigidbody2D lastRope)
    {
        HingeJoint2D joint = gameObject.AddComponent<HingeJoint2D>();
        joint.autoConfigureConnectedAnchor = false;
        joint.connectedBody = lastRope;
        joint.anchor = Vector2.zero;
        joint.connectedAnchor = new Vector2(0f, -distanceBalltoRope);

    }
}
