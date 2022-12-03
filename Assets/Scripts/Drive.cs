using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour
{
    float posY;
    float posX;
    public bool isDestroy;
    
    public GameController gamecontroller;
    public Road road;

    [SerializeField] GameObject carDestroy;

    float i=0;

    public float multiplicador;
    
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
            road.speedRoad = road.speedRoad + multiplicador * Time.deltaTime;
            multiplicador = multiplicador + 0.0001f;
            
        }

        if (posY >-3)
        {
            road.speedRoad = road.speedRoad + multiplicador * Time.deltaTime;
            multiplicador = multiplicador + 0.0002f;
        }


        if (posX <-1.8 || posX > 1.8)
        {
            GameOver();
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

    public void GameOver()
    {       
        isDestroy = true;
        carDestroy.active = true;
        posY = posY - 3f * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, i);
        i = i + 0.05f * Time.time;
    }

    
}
