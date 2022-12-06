using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraExitGame : MonoBehaviour
{
    
    // No utilizado por el momento
    void Start()
    {
        
    }

    void Update()
    {
        // Si se pulsa "Return" recarga la escena y quita la pausa en el caso de que el tiempo esté detenido
        if(Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            ReplayGame();
        }
        // Si se pulsa "Escape" se sale del juego y vuelve al menú de inicio. Resetea el tiempo de la pausa
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            MenuGame();
        }

    }

    // Recarga la escena
    public void ReplayGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }

    // Vuelve al menú de inicio
    public void MenuGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Menu");
    }
}
