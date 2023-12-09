using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float playerSpeed;
    public Rigidbody rb;

    public bool itHasBegun = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(new Vector3(0, -playerSpeed), ForceMode.Acceleration);
        if(itHasBegun)
            rb.velocity = new Vector3(0, -playerSpeed, 0);
        else rb.velocity = new Vector3(0, 0, 0);
    }

    public void StartMatch()
    {
        itHasBegun = true;
    }
}
