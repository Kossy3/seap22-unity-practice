using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Text text = this.GetComponent<Text>();
        text.text = Data.data.score.ToString(); 
    }
}
