using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public void Start()
    {
        int myScore = Data.data.score;
        int[] scoreRanking = GetScoreRanking(myScore);
        
        Transform topThreeText = this.transform.Find("TopThree").transform;
        Transform myScoreText = this.transform.Find("MyScore").transform;

        if (scoreRanking != null)
        {
            for (int i = 0; i < 3; i++)
            {
                DisplayScore(topThreeText.GetChild(i).transform, i+1, scoreRanking[i]);
            } 

            //ArrayはSystemのnamespaceから
            DisplayScore(myScoreText, Array.IndexOf(scoreRanking, myScore), myScore);
        }
        else
        {
            for (int i = 0; i < 3; i++)
            {
                DisplayScore(topThreeText.GetChild(i).transform, i+1, 0);
            }

            DisplayScore(myScoreText, 0, myScore);
        }        
    }

    private int[] GetScoreRanking(int score)
    {
        return null;
    }

    private void DisplayScore(Transform scoreText, int rank, int score)
    {
        Text rankText = scoreText.Find("Rank").GetComponent<Text>();
        Text scoretext = scoreText.Find("Score").GetComponent<Text>();

        if (score != 0)
        {
            int minutes = score / 60;
            int seconds = score % 60;

            scoretext.text = minutes + ":" + seconds;
        }
        else
        {
            scoretext.text = "--:--";
        }

        if (rank != 0)
        {
            rankText.text = rank + "位";
        }
        else
        {
            rankText.text = "-位";
        }
    }
}
