using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int myRank;
    private int[] scoreRanking;

    public void Start()
    {
        int myScore = Data.data.score;
        
        Transform topThreeText = this.transform.Find("TopThree").transform;
        Transform myScoreText = this.transform.Find("MyScore").transform;

        if (GetScoreRanking(myScore))
        {
            for (int i = 0; i < 3; i++)
            {
                DisplayScore(topThreeText.GetChild(i).transform, i+1, scoreRanking[i]);
            } 

            DisplayScore(myScoreText, myRank, myScore);
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

    //通信失敗時、falseをreturn
    private bool GetScoreRanking(int score)
    {
        try 
        {
            //myRank = ;
            //scoreRanking = ;
            return true;
        }
        catch
        {
            return false;
        }
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
