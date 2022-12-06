using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraFuel : MonoBehaviour
{
    // Imagen para la barra de fuel
    public Image fuelBar;
    // Fuel actual
    public float currentFuel = 100F;
    // Fuel máximo
    public float maxFuel = 100f;
    // Camión que destruye al player
    public GameObject truck;
    // Posición dónde poner el camión que destruirá al player cuando se quede sin fuel
    public Transform spawnTruckPosition;
    // Booleano del fuel para saber si ya lo ha lanzado (al camión)
    [SerializeField] bool fuelOut;

    // No utilizado por el momento
    void Start()
    {

    }

    
    void Update()
    {
        // Si el fuel es 0 y no está el camión en pantalla, lo lanza para destruir al player
        if (currentFuel <0 && fuelOut == false)
        {
            currentFuel = 0;
            fuelOut = true;
            Instantiate(truck, spawnTruckPosition.transform.position, Quaternion.identity);
        }

        // Si el fuel actual es mayor que el máximo, lo iguala
        if (currentFuel > maxFuel)
        {
            currentFuel = maxFuel;
        }

        // Resta el fuel continuamente
        currentFuel = currentFuel - 2f * Time.deltaTime;
        // Muestra la barra del fuel en el canvas
        fuelBar.fillAmount = currentFuel / maxFuel;
    }
}
