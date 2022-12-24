using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    private Timer timer = null;

    void Start()
    {
        timer = GameObject.Find("Timer").GetComponent<Timer>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "hitsuji_dot")
        {
            Data.data.score = (int)timer.totalTime;
            SceneManager.LoadScene("Score");
        }
    }
}
