using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public Text scoreText;
    public Text rivalScoreText;

    int score = 0;
    int rivalScore = 0;


    private void Awake(){
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
        rivalScoreText.text = rivalScore.ToString();
    }

    public void RivalAddPoints(){
        rivalScore += 1;
        rivalScoreText.text = rivalScore.ToString();
    }

    public void AddPoint(){
        score += 1;
        scoreText.text = score.ToString();
    }
}