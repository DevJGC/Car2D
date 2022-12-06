using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Drive : MonoBehaviour
{
    // Variables del coche X e Y
    float posY;
    float posX;

    // Booleano  para saber si el coche está "vivo"
    public bool isDestroy;
    
    // Variable para la velocidad del coche
    public GameController gamecontroller;
    // Variable para la velocidad del la carretera
    public Road road;

    // Referencia al objeto "Canvas" para poder acceder a sus componentes
    [SerializeField] GameObject carDestroy;

    // Variable parcial
    float i=0;

    // Multiplicador de velocidad
    public float multiplicador;
    // Booleano para controlar el final del juego
    public bool isGameOver;

    // Referencia al Canvas 
    [SerializeField] Text textGameOver;
    // Referencia a las partículas cuando sale de la carretera por la izquierda o derecha
    [SerializeField] GameObject particlesLeft;
    [SerializeField] GameObject particlesRight;
    // Collider del coche
    [SerializeField] BoxCollider2D bc2d;
    // RigidBody del coche
    [SerializeField] Rigidbody2D rb2d;
    // Referencia al Spawner
    [SerializeField] GameObject spawner;

    
    void Start()
    {
        // Inicializamos las variables
        gamecontroller = FindObjectOfType<GameController>();
        road = FindObjectOfType<Road>();       
        rb2d = GetComponent<Rigidbody2D>();
        // Control de dificultad - Modificar o referenciado para posibles cambios
        spawner.GetComponent<Spawner>().maxSpawn = 0.6f;     
    }

    
    void Update()
    {
        // Posición del coche en el eje X e Y
        posY = transform.position.y;
        posX = transform.position.x;
        // Cuando el coche aparece, sube hasta una posición concreta
        if (posY <-3)
        {
            posY = posY + 1f * Time.deltaTime;
            road.speedRoad = road.speedRoad + multiplicador * Time.deltaTime;
            multiplicador = multiplicador + 0.1f * Time.deltaTime;         
        }
        // Cuando ya está en su posición, se fija la velocidad de la carretera y la dificultad
        if (posY >-3)
        {
            road.speedRoad = road.speedRoad + multiplicador * Time.deltaTime;
            multiplicador = multiplicador + 0.2f * Time.deltaTime;           
        }
        // Limites izquierda y derecha para eliminar al coche
        if (posX <-1.8 || posX > 1.8)
        {
            isGameOver = true;
            GameOver();
        }
        // Limites para mostrar partículas cuando sale de la carretera
        if (posX <-1.5f)
        {
            particlesLeft.SetActive(true);
        }
        if (posX > -1.1)
        {
            particlesLeft.SetActive(false);
        }
        // Limites para mostrar partículas cuando sale de la carretera
        if (posX > 1.5f)
        {
            particlesRight.SetActive(true);
        }
        if (posX < 1.1f)
        {
            particlesRight.SetActive(false);
        }
        
        // Si el juego está en marcha, activa movimiento controlador
        if (isGameOver == false && multiplicador>0.05f)
        {
            CarMovement();
        }

        // Fija un máximo en el multiplicador de dificultad
        if (multiplicador>4)
        {
            multiplicador=4;
            //spawner.GetComponent<Spawner>().maxSpawn = 0.6f;   
        }
        // Mueve coche según los valores de las variables
        transform.position = new Vector3(posX, posY, transform.position.z);  
    }

    // Control de movimiento del coche
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
    // GameOver - Para el Spawner - Cambia booleano - Activa "muerte" coche - Baja al coche y lo rota y lanza corrutina
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

    // Corrutina para destruir el coche
    IEnumerator DestroyCar()
    {
        yield return new WaitForSeconds(1.5f);
        textGameOver.text = "Game Over";
        Destroy(gameObject);
    }

    // Control de colisiones - si choca con enemigo le da gravedad - lo rota - desactiva colliders y rigidbody 
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
