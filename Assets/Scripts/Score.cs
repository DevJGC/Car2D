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
        record = (int)record;
        record = PlayerPrefs.GetFloat("Record",0);
        recordText.text = record.ToString();
       
        
    }

    void Update()
    {
        //score = score + 0.001f * Time.time;
        score = score + 1f * Time.deltaTime;
        scoreText.text = score.ToString("0");

        if (score > record)
        {
            
            record = score;
            record=(int)record;

            PlayerPrefs.SetFloat("Record",record);

            recordText.text = record.ToString("0");

        }
        
    }
}
