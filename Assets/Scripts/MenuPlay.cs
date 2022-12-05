using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class MenuPlay : MonoBehaviour
{

    void Start()
    {
        
    }

    
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                PlayGame();
            }

    
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
