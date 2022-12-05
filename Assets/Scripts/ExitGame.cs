using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGame : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {

            Application.Quit();
            UnityEditor.EditorApplication.isPlaying = false;

        }
        
    }
}
