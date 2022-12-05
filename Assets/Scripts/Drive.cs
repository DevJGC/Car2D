using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    public bool isGameOver;

    [SerializeField] Text textGameOver;
    [SerializeField] GameObject particlesLeft;
    [SerializeField] GameObject particlesRight;
    [SerializeField] BoxCollider2D bc2d;
    [SerializeField] Rigidbody2D rb2d;
    [SerializeField] GameObject spawner;

    
    void Start()
    {
        gamecontroller = FindObjectOfType<GameController>();
        road = FindObjectOfType<Road>();       
        rb2d = GetComponent<Rigidbody2D>();
        
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
            multiplicador = multiplicador + 0.0002f * Time.deltaTime;
            
        }


        if (posX <-1.8 || posX > 1.8)
        {
            isGameOver = true;
            GameOver();
        }




        if (posX <-1.5f)
        {
            particlesLeft.SetActive(true);
        }

        if (posX > -1.1)
        {
            particlesLeft.SetActive(false);
        }

        if (posX > 1.5f)
        {
            particlesRight.SetActive(true);
        }
        if (posX < 1.1f)
        {
            particlesRight.SetActive(false);
        }
        



     

        if (isGameOver == false && multiplicador>0.05f)
        {
            CarMovement();
        }

        if (multiplicador>2)
        {
            multiplicador=2;
            spawner.GetComponent<Spawner>().maxSpawn = 0.6f;
            
            
        }


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
        //isGameOver = true;
        
        Destroy(spawner);
        isDestroy = false;
        carDestroy.active = true;
        posY = posY - 3f * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0, 0, i);
        i = i + 0.05f * Time.time;
        StartCoroutine(DestroyCar());
    }

    IEnumerator DestroyCar()
    {
        yield return new WaitForSeconds(1.5f);
        textGameOver.text = "Game Over";
        Destroy(gameObject);

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {

            rb2d.gravityScale = 1;
            rb2d.AddTorque(Random.Range(-100f,100f));
            bc2d.enabled = false;
            isGameOver = true;
            GameOver();
           
        }
    }

    
}
