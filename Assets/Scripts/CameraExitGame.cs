using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExitGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            ReplayGame();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            MenuGame();
        }

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
