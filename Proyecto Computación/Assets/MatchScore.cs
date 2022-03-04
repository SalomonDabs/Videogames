using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchScore : MonoBehaviour
{
    [SerializeField] int points;

    void OnCollisionEnter2D(Collision2D col)
    {   
        if(col.gameObject.name == "SoccerBall"){
            points++;
            ScoreManager.instance.AddPoint();
        }
        
    }

}
