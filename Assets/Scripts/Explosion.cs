using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] GameObject car;

    [SerializeField] BarraFuel barraFuel;

    [SerializeField] Score score;

    [SerializeField] GameObject canvasReplay;

    void Start()
    {

        car = GameObject.Find("Car");
        transform.position = car.transform.position;
        barraFuel = FindObjectOfType<BarraFuel>();
        barraFuel.enabled = false;
        score = FindObjectOfType<Score>();
        score.enabled = false;

        canvasReplay.SetActive(true);

        // Poner un reset Time.deltaTime o algo similar

        


    }

    
    void Update()
    {
        
    }
}
