﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projetil : MonoBehaviour
{
    [SerializeField]
    public float speed;

    public float bulletDmg = 1f;

    private float timerSelfDestruct = 0;
    private float timerSelfDestruct_Max = 5;

    private Rigidbody2D rgbd;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
        timerSelfDestruct = Time.time;
        rgbd.velocity = transform.up * speed;
    }

    void Update()
    {
        if (Time.time >= timerSelfDestruct + timerSelfDestruct_Max)
        {
            Destroy(gameObject);

            timerSelfDestruct = Time.time;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Armadilha")
        {
            Destroy(collision.gameObject);

            Destroy(gameObject);
        }
    }
}