using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Road : MonoBehaviour
{
    [SerializeField] RawImage ground;

    void Start()
    {
        ground = GetComponent<RawImage>();

    }

   
    void FixedUpdate()
    {
        ground.uvRect = new Rect(ground.uvRect.x, ground.uvRect.y + 0.01f, ground.uvRect.width, ground.uvRect.height);
    }

}
