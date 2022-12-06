using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Referencia del collider y rigidbody de los enemigos
    [SerializeField] BoxCollider2D bc2d;
    [SerializeField] Rigidbody2D rb2d;

    // Inicializa los componentes y asigna una gravedad aleatoria en el Start
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        rb2d.gravityScale = Random.Range(0.2f,0.4f);   
    }

    // No utilizado por el momento
    void Update()
    {
        
    }

    // Si el enemigo colisiona con el jugador, se destruye y rota y desactiva componentes de colisión
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            bc2d.enabled = false;
            rb2d.gravityScale = 1;
            rb2d.AddTorque(Random.Range(-100f,100f));
            StartCoroutine(DestroyEnemy());
        }
    }

    // Destruye el enemigo después de 2 segundos
    IEnumerator DestroyEnemy()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }
}
