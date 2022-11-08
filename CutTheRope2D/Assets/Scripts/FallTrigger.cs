using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTrigger : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TargetObject"))
        {
            gameManager.FallTargetObject();
        }
        else if (other.gameObject.CompareTag("Ball"))
        {
            gameManager.FallBall();
        }
    }
}
