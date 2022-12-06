using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    // Referencia de Audio y sus clips
    [SerializeField] AudioSource countSource;
    [SerializeField] AudioClip one;
    [SerializeField] AudioClip go;
    // Texto del canvas contador
    public Text countText;
    // Tiempo de espera entre cada clip
    [SerializeField] float timeLeftPartial = 1f;
    // Variable contador
    int count;
   
   // Valor para la cuenta a tras de inicio
    void Start()
    {
        count = 3;
    }

    
    void Update()
    {
        // Contador parcial
        timeLeftPartial -= Time.deltaTime;
        // Entra siempre que el contador parcial sea menor que 0
        if (timeLeftPartial < 0)
        {
            // Muestra sonido de cuenta regresiva
            if (count == 3 || count == 2 || count == 1)
            {
                countSource.PlayOneShot(one);
            }
           
           // Resta el contador y restaura el parcial
            count = count - 1;
            timeLeftPartial = 1f;

        }
        // Muestra el texto del contador
        if (count>0)
        {
         countText.text = count.ToString();
        }
        // Cuando el contador llega a 0, muestra texto y sonido "go!"
        if (count == 0)
        {
            countSource.PlayOneShot(go);
            countText.text = "GO!";
        }
        // Cuando el contador llega a -1, borra el texto
        if (count == -1)
        {
            countText.text = "";
        }            
    }
}
