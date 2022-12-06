using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    public bool isPaused = false;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject pauseResume;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioSource ambientSource;


    void Start()
    {
        //Time.timeScale = 0;
    }

    
    void Update()
    {
        
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
        audioSource.Pause();
        ambientSource.Pause();
        isPaused = true;
        pauseResume.SetActive(true);
        pauseMenu.SetActive(false);
        
     
    }

    public void ResumeGame()
    {
        //Debug.Log("Estoy en pausa");
        Time.timeScale = 1;
        audioSource.Play();
        ambientSource.Play();
        isPaused = false;
        pauseResume.SetActive(false);
        pauseMenu.SetActive(true);
        
        

    }
}
