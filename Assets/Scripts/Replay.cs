using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
    public Button replayButton;
    public Button menuButton;

    [SerializeField] AudioSource clicSource;
    [SerializeField] AudioClip clicClip;

  
    void Start()
    {
        
    }

 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            clicSource.PlayOneShot(clicClip);
            ReplayGame();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            clicSource.PlayOneShot(clicClip);
            MenuGame();
        }

    }


    public void ReplayGame()
    {
        clicSource.PlayOneShot(clicClip);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    public void MenuGame()
    {
        clicSource.PlayOneShot(clicClip);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
