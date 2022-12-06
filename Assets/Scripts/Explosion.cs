using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    // Referencia objetos para gestionar la explisión del jugador 
    // Objeto Coche
    [SerializeField] GameObject car;
    // Barra del Fuel del canvas
    [SerializeField] BarraFuel barraFuel;
    // Referencia el score del canvas
    [SerializeField] Score score;
    // Referencia el canvas del Replay
    [SerializeField] GameObject canvasReplay;

    void Start()
    {
        // Inicializamos el canvas del Replay
        car = GameObject.Find("Car");
        transform.position = car.transform.position;
        barraFuel = FindObjectOfType<BarraFuel>();
        barraFuel.enabled = false;
        score = FindObjectOfType<Score>();
        score.enabled = false;
        canvasReplay.SetActive(true);
    }

    // No utilizado por el momento
    void Update()
    {
        
    }
}
