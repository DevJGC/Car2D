using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
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
            count = count - 1;
            timeLeftPartial = 1f;
        }

        if (count>0)
        {
         countText.text = count.ToString();
        }
        if (count == 0)
        {
            countText.text = "GO!";
        }
        if (count == -1)
        {
            countText.text = "";
        }
       
        
    }


}
