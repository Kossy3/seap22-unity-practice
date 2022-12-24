using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private Text Text = null;
    public float totalTime = 0f;
    private int minutes = 0;
    private int seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
        Text = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        minutes = (int)(totalTime / 60);
        seconds = (int)(totalTime % 60);
        Text.text = minutes.ToString("D2") + ":" + seconds.ToString("D2");
    }
}
