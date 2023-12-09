using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shapeshift : MonoBehaviour
{
    public int currentForm;
    public GameObject[] forms;
    public GameObject[] particles;

    public bool dead = false;
    public GameObject death;

    public int currentColor;
    public Material[] colors;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(dead)
        {
            forms[0].SetActive(false);
            forms[1].SetActive(false);
            forms[2].SetActive(false);
            death.SetActive(true);
        }
    }

    public void ChangeForm() 
    {
        currentForm++;
        if (currentForm > 2)
            currentForm = 0;

        if(currentForm == 0)
        {
            forms[2].SetActive(false);
            forms[0].SetActive(true);
            particles[2].SetActive(false);
            particles[0].SetActive(true);
        } else if(currentForm == 1)
        {
            forms[0].SetActive(false);
            forms[1].SetActive(true);
            particles[0].SetActive(false);
            particles[1].SetActive(true);
        }
        else if (currentForm == 2)
        {
            forms[1].SetActive(false);
            forms[2].SetActive(true);
            particles[1].SetActive(false);
            particles[2].SetActive(true);
        }
    }

    public void ChangeColor()
    {
        currentColor++;
        if (currentColor > 2)
            currentColor = 0;

        forms[0].GetComponent<Renderer>().material = colors[currentColor];
        forms[1].GetComponent<Renderer>().material = colors[currentColor];
        forms[2].GetComponent<Renderer>().material = colors[currentColor];
        particles[0].GetComponent<Renderer>().material = colors[currentColor];
        particles[1].GetComponent<Renderer>().material = colors[currentColor];
        particles[2].GetComponent<Renderer>().material = colors[currentColor];
    }
}
