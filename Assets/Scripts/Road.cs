using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Road : MonoBehaviour
{
    public float speedRoad;
    public GameController gamecontroller;
    [SerializeField] Renderer ground;

    void Start()
    {
        ground = GetComponent<Renderer>();
        gamecontroller = FindObjectOfType<GameController>();
        speedRoad = 0.001f;
    }

   
    void FixedUpdate()
    {
        if (gamecontroller.onPlay)
        {
            ground.material.mainTextureOffset = new Vector2(0, Time.time * speedRoad);
        } 

    }

}
