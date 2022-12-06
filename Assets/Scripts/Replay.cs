using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Replay : MonoBehaviour
{
    // Referencia de los botones del canvas
    public Button replayButton;
    public Button menuButton;

    // Referencia de los sonidos del canvas
    [SerializeField] AudioSource clicSource;
    [SerializeField] AudioClip clicClip;

    // No utilizado por el momento
    void Start()
    {
        
    }

    // Si se pulsa "Intro" recarga escena - Si se pulsa "Escape" sale al menú
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

    // Carga la escena Game
    public void ReplayGame()
    {
        clicSource.PlayOneShot(clicClip);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    // Carga la escena Menu
    public void MenuGame()
    {
        clicSource.PlayOneShot(clicClip);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
