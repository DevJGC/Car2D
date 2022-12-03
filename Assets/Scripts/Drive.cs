using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    float posY;
    float posX;
    
    public GameController gamecontroller;
    public Road road;
    
    void Start()
    {
        gamecontroller = FindObjectOfType<GameController>();
        road = FindObjectOfType<Road>();
        
    }

    
    void Update()
    {
        posY = transform.position.y;
        posX = transform.position.x;

        if (posY <-3)
        {
            posY = posY + 1f * Time.deltaTime;
            road.speedRoad = road.speedRoad + 0.01f * Time.deltaTime;
            
        }

        if (posY >-3)
        {
            road.speedRoad = road.speedRoad + 0.02f * Time.deltaTime;
        }

        CarMovement();

        transform.position = new Vector3(posX, posY, transform.position.z);

        
        
    }

    public void CarMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            posX = posX - 1f * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            posX = posX + 1f * Time.deltaTime;
        }

    }

    
}
