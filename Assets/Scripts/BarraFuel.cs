using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraFuel : MonoBehaviour
{
    public Image fuelBar;
    public float currentFuel = 100F;
    public float maxFuel = 100f;

    


    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (currentFuel <0)
        {
            currentFuel = 0;
        }

        if (currentFuel > maxFuel)
        {
            currentFuel = maxFuel;
        }

        currentFuel = currentFuel - 0.0002f * Time.time;
        
        fuelBar.fillAmount = currentFuel / maxFuel;


    }
}
