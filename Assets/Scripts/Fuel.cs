using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    // Referencias del collider del objeto Fuel
    [SerializeField] BoxCollider2D bc2d;
    [SerializeField] Rigidbody2D rb2d;

    // Referencia la barra de Fuel
    [SerializeField] BarraFuel barraFuel;

    // Referencia el audio
    [SerializeField] AudioSource fuelSource;
    [SerializeField] AudioClip fuelClip;

    void Start()
    {
        // Inicializamos el collider y el rigidbody
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        // Se le asigna una velocidad de caida aleatoria al inicio
        rb2d.gravityScale = Random.Range(0.2f,0.4f);
        // Inicializado la barra de fuel
        barraFuel = FindObjectOfType<BarraFuel>();        
    }
    
    // No utilizado por el momento
    void Update()
    {
        
    }

    // Cuando el objeto Fuel colisiona con el jugador
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        // Se reproduce el audio
        fuelSource.PlayOneShot(fuelClip);
        // Se le suma 100 de fuel a la barra       
        barraFuel.currentFuel = barraFuel.currentFuel + 100f;
        // Se destruye el objeto Fuel
        Destroy(gameObject,0.2f);
        }
        // Destruye el objeto Fuel si se sale de la pantalla
        if (other.gameObject.tag == "Finish")
        {     
            Destroy(gameObject);
        }
    }
}
