using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraFuel : MonoBehaviour
{
    public Image fuelBar;
    public float currentFuel = 100F;
    public float maxFuel = 100f;

    public GameObject truck;
    
    public Transform spawnTruckPosition;
    [SerializeField] bool fuelOut;


    


    
    void Start()
    {
       


    }


    
    void Update()
    {
        if (currentFuel <0 && fuelOut == false)
        {
            currentFuel = 0;
            fuelOut = true;
            Instantiate(truck, spawnTruckPosition.transform.position, Quaternion.identity);
        }

        if (currentFuel > maxFuel)
        {
            currentFuel = maxFuel;
        }

        currentFuel = currentFuel - 2f * Time.deltaTime;
        
        fuelBar.fillAmount = currentFuel / maxFuel;


    }
}
