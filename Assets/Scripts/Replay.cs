using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
    public Button replayButton;
    public Button menuButton;
  
    void Start()
    {
        
    }

 
    void Update()
    {
        
    }


    public void ReplayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void MenuGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
