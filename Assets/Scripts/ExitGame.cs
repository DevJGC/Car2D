using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{
    // Restaura el tiempo si ha estado en pausa
    void Start()
    {
        Time.timeScale = 1;
        // Descomentar la siguiente línea para restaurar Record
        //PlayerPrefs.SetFloat("Record",0);  
    }
    
    void Update()
    {
        // Si se pulsa la tecla Escape, se sale del juego y del editor
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;
        }        
    }
}
