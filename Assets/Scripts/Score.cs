using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        score = Data.data.score;

        int minutes = score / 60;
        int seconds = score % 60;

        text.text = "スコア　" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
    }
}
