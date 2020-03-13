using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanhaoMovimento : MonoBehaviour
{   
    Rigidbody2D rb;
    
    Vector2 mousePos;

    public Camera cam;

    [SerializeField]
    private Transform Tanque;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cam = Camera.main;
    }

    void FixedUpdate()
    {
        transform.position = Tanque.transform.position;

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

        Vector2 OlharDirecao = mousePos - rb.position;

        float angle = Mathf.Atan2(OlharDirecao.y,OlharDirecao.x) * Mathf.Rad2Deg-90f;
        
        rb.rotation = angle; 
    }
}
