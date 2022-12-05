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
            ReplayGame();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
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
