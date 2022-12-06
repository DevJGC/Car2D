using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    // Booleado de la pausa
    public bool isPaused = false;
    // Referencias a los objetos de la interfaz
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseResume;
    // Referencias los sonidos para poder parar y lanzar el audio durante la pausa
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource ambientSource;

    // No utilizado por el momento
    void Start()
    {
        //Time.timeScale = 0;
    }

    // No utilizado por el momento
    void Update()
    {
        
    }

    // Método para lanzar desde el Canvas cuando se pulsa Pause
    public void PauseGame()
    {
        // Pausa el tiempo - Pausa sonidos - Activa/Desactiva botones de pausa
        Time.timeScale = 0;
        audioSource.Pause();
        ambientSource.Pause();
        isPaused = true;
        pauseResume.SetActive(true);
        pauseMenu.SetActive(false);        
    }

    // Método para lanzar desde el Canvas cuando se quita el Pause
    public void ResumeGame()
    {
        // Restaura el tiempo - Lanza sonidos - Activa/Desactiva botones de pausa
        Time.timeScale = 1;
        audioSource.Play();
        ambientSource.Play();
        isPaused = false;
        pauseResume.SetActive(false);
        pauseMenu.SetActive(true);    
    }
}
