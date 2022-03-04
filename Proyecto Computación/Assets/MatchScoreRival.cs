using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchScoreRival : MonoBehaviour
{
    [SerializeField] int points;

    void OnCollisionEnter2D(Collision2D col)
    {   
        if(col.gameObject.name == "SoccerBall"){
            points++;
            ScoreManager.instance.RivalAddPoints();
        }
    }

}
