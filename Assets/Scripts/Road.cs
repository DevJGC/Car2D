using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Road : MonoBehaviour
{
    public float speedRoad;
    public GameController gamecontroller;
    [SerializeField] Renderer ground;

    [SerializeField] Drive drive;

    void Start()
    {
        ground = GetComponent<Renderer>();
        gamecontroller = FindObjectOfType<GameController>();
        speedRoad = drive.multiplicador;
    
    }

   
    void FixedUpdate()
    {
        if (gamecontroller.onPlay)
        {
            ground.material.mainTextureOffset = new Vector2(0, speedRoad);
            speedRoad += drive.multiplicador * Time.deltaTime;
        } 

    }

    void Update()
    
    {
        if (drive.isDestroy==true && drive.multiplicador >0)

        {
            drive.multiplicador = drive.multiplicador - 0.001f;
        }

    }



}
