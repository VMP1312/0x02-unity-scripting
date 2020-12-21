﻿using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // Get info from User to move in the X and Y axis
        float XInput = Input.GetAxis("Horizontal");
        float ZInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (XInput, 0.0f, ZInput);
        
        rb.AddForce(movement * speed);
    }
}