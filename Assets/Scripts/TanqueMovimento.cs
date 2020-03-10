using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueMovimento : MonoBehaviour
{
    public float movSpeed;

    Rigidbody2D righ;

    [SerializeField]
    Vector2 movement;

    Animator animator;

    void Awake()
    {
        righ = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    private void FixedUpdate()
    {
        righ.MovePosition(righ.position + movement * movSpeed * Time.fixedDeltaTime);
    }
}
