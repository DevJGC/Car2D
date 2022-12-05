using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StoreDataMenu : MonoBehaviour
{
    float record;

    public Text recordNumber;


    void Start()
    {
        record = PlayerPrefs.GetFloat("Record",0);
        PlayerPrefs.SetFloat("Record",record);
        record = (int)record;
        recordNumber.text = record.ToString();



    }

    
    void Update()
    {
       // recordNumber.text = record.ToString();
    }
}
