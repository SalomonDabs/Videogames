using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPosition : MonoBehaviour
{
    GameObject ball;

    void OnCollisionEnter2D(Collision2D col)
    {   
        if(col.gameObject.name == "Goal Wall_rival" || col.gameObject.name == "Goal Wall"){
            transform.position = new Vector3 (-6.48f, 1.51f, -0.05f);
            GetComponent<Rigidbody2D>().velocity = Vector3.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0;
        }
    }
}