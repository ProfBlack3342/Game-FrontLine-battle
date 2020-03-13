using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Bullet : NetworkBehaviour
{
    public float speed;

    private float timerSelfDestruct = 0;
    private float timerSelfDestruct_Max = 5;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        timerSelfDestruct = Time.time;
        rb.velocity = transform.up * speed;
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
        if (collision.tag == "Player" || collision.tag == "Trap" || collision.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
