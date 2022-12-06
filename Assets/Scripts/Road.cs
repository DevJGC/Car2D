using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Road : MonoBehaviour
{
    // Variable velocidad textura carretera
    public float speedRoad;
    // Referencia al controlador
    public GameController gamecontroller;
    // Referencia al material de la carretera
    [SerializeField] Renderer ground;
    // Referencia al Script del coche
    [SerializeField] Drive drive;

    // Inicializa componentes
    void Start()
    {
        ground = GetComponent<Renderer>();
        gamecontroller = FindObjectOfType<GameController>();
        speedRoad = drive.multiplicador;
    
    }

    // Actualiza la velocidad de la carretera y la textura
    void FixedUpdate()
    {
        if (gamecontroller.onPlay)
        {
            ground.material.mainTextureOffset = new Vector2(0, speedRoad);
            speedRoad += drive.multiplicador * Time.deltaTime;
        } 
    }
    
    // Frena la velocidad de la carretera
    void Update()  
    {
        if (drive.isGameOver==true && drive.multiplicador >0)
        {
            drive.multiplicador = drive.multiplicador - 0.001f;
        }
    }
}
