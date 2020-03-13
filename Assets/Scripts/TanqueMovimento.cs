﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TanqueMovimento : NetworkBehaviour
{
    public float movSpeed;

    private Rigidbody2D rb;
    private Vector2 movement;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (isLocalPlayer)
        {
            movement.x = Input.GetAxisRaw("Horizontal");
            movement.y = Input.GetAxisRaw("Vertical");

            rb.MovePosition(rb.position + movement * movSpeed * Time.fixedDeltaTime);
        }
    }
}
