using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{

    [SerializeField] AudioSource countSource;
    [SerializeField] AudioClip one;
    [SerializeField] AudioClip go;
    public Text countText;
    [SerializeField] float timeLeftPartial = 1f;
    int count;
   
    void Start()
    {
        count = 3;
    }

    
    void Update()
    {
       // count = count - Time.deltaTime;
        timeLeftPartial -= Time.deltaTime;
        if (timeLeftPartial < 0)
        {

            if (count == 3 || count == 2 || count == 1)
            {
                countSource.PlayOneShot(one);
            }
           
            count = count - 1;
            timeLeftPartial = 1f;



            
        }

        if (count>0)
        {
         countText.text = count.ToString();
        }
        if (count == 0)
        {
            countSource.PlayOneShot(go);
            countText.text = "GO!";
        }
        if (count == -1)
        {
            countText.text = "";
        }
       
        
    }


}
