using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ColorRandomizer : MonoBehaviour
{
    public Material[] colors;
    public int myColor;

    // Start is called before the first frame update
    void Awake()
    {
        myColor = Random.Range(0,3);
        gameObject.GetComponent<Renderer>().material = colors[myColor];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
