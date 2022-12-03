using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] GameObject car;

    void Start()
    {
        car = GameObject.Find("Car");
        transform.position = car.transform.position;
    }

    
    void Update()
    {
        
    }
}
