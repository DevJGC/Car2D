using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // Referencia al canvas
    public Text scoreText;
    public Text recordText;

    // Puntuación y Record
    public float score = 0;
    public float record;

    // Convierte en INT el record - Carga al inicio el Record y lo muestra por el canvas
    void Start()
    {
        record = (int)record;
        record = PlayerPrefs.GetFloat("Record",0);
        recordText.text = record.ToString();
    }

    // Actualiza la puntuación y el record
    void Update()
    {
        // Suma puntos y lo muestra en el canvas
        //score = score + 0.001f * Time.time;
        score = score + 1f * Time.deltaTime;
        scoreText.text = score.ToString("0");

        // Actualiza el record - Lo pasa a INT y lo guarda en memoria y lo muestra en el canvas
        if (score > record)
        {    
            record = score;
            record=(int)record;
            PlayerPrefs.SetFloat("Record",record);
            recordText.text = record.ToString("0");
        }      
    }
}
