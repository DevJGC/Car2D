using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text recordText;

    public float score = 0;
    public float record;

    void Start()
    {
        
    }

    void Update()
    {
        score = score + 0.001f * Time.time;
        scoreText.text = score.ToString("0");

        if (score > record)
        {
            record = score;
            recordText.text = record.ToString("0");

        }
        
    }
}
