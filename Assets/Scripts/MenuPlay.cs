using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//using UnityEngine.UI;

public class MenuPlay : MonoBehaviour
{

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

                PlayGame();
            }

    
        
    }

    public void PlayGame()
    {
        clicSource.PlayOneShot(clicClip);
        SceneManager.LoadScene("Game");
    }
}
