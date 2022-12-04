using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    [SerializeField] GameObject car;

    [SerializeField] BarraFuel barraFuel;

    [SerializeField] Score score;

    void Start()
    {
        car = GameObject.Find("Car");
        transform.position = car.transform.position;
        barraFuel = FindObjectOfType<BarraFuel>();
        barraFuel.enabled = false;
        score = FindObjectOfType<Score>();
        score.enabled = false;


    }

    
    void Update()
    {
        
    }
}
