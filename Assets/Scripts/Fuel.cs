using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] BoxCollider2D bc2d;
    [SerializeField] Rigidbody2D rb2d;

    [SerializeField] BarraFuel barraFuel;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();

        rb2d.gravityScale = Random.Range(0.2f,0.4f);

        barraFuel = FindObjectOfType<BarraFuel>();
        
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            //Debug.Log("Fuel");
            barraFuel.currentFuel = barraFuel.currentFuel + 100f;
            Destroy(gameObject);

        }

        if (other.gameObject.tag == "Finish")
        {
            //Debug.Log("Fuel");
           
            Destroy(gameObject);

        }

        


    }


}
