﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroDoPlayer : MonoBehaviour
{
    public Rigidbody2D bullet;
    public Transform bulletExit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootAt();
        }     
    }

    void ShootAt()
    {
        Rigidbody2D bulletRgbd = Instantiate(bullet, bulletExit.position, bulletExit.rotation);           
    }
}
