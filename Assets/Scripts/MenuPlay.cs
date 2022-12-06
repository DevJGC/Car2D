using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class MenuPlay : MonoBehaviour
{
    // Referencia los sonidos
    [SerializeField] AudioSource clicSource;
    [SerializeField] AudioClip clicClip;
    
    // No utilizado por el momento
    void Start()
    {
        
    }

    // Si se pulsa Return, lanza escena Game
    void Update()
    {
            if(Input.GetKeyDown(KeyCode.Return))
            {
                clicSource.PlayOneShot(clicClip);
                PlayGame();
            }
    }

    // Lanza escena Game
    public void PlayGame()
    {
        clicSource.PlayOneShot(clicClip);
        SceneManager.LoadScene("Game");
    }
}
