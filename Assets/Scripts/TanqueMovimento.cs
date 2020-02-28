using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TanqueMovimento : MonoBehaviour
{
    public float MoveSpeed;

    Rigidbody2D righ;

    [SerializeField]
    Vector2 moviment;

    Animator animator;

    void Awake()
    {
        righ = GetComponent<Rigidbody2D>();

        animator = GetComponent<Animator>();
    }

    void Update()
    {
        moviment.x = Input.GetAxisRaw("Horizontal");
        moviment.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal",moviment.x);
        animator.SetFloat("Vertical", moviment.y);
        animator.SetFloat("Speed", moviment.sqrMagnitude); //??
    }

    private void FixedUpdate()
    {
        righ.MovePosition(righ.position + moviment * MoveSpeed * Time.fixedDeltaTime);
    }
}
