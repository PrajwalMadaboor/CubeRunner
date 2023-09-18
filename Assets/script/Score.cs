using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text finalScoreText;
    int myScore = 0;

    void Update()
    {

        scoreText.text = myScore.ToString();
        finalScoreText.text = "Score:" + myScore.ToString();



    }
    public void AddScore(int score)
    {

        myScore = myScore + score;

    }

}
