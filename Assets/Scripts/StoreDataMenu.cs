using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreDataMenu : MonoBehaviour
{
    // Variable record
    float record;
    // Referencia al Canvas 
    public Text recordNumber;


    void Start()
    {
        // Carga el record
        record = PlayerPrefs.GetFloat("Record",0);
        // Lo guarda en memoria
        PlayerPrefs.SetFloat("Record",record);
        // Lo pasa a INT y lo muestra en el canvas
        record = (int)record;
        recordNumber.text = record.ToString();
    }

    // No utilizado por el momento
    void Update()
    {
       // recordNumber.text = record.ToString();
    }
}
