using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
  
    [SerializeField] BoxCollider2D bc2d;
    [SerializeField] Rigidbody2D rb2d;
    void Start()
    {
        
        rb2d = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            bc2d.enabled = false;
            rb2d.gravityScale = 1;
            rb2d.AddTorque(Random.Range(-100f,100f));
        }
    }
}
