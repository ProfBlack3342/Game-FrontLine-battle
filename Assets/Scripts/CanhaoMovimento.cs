using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanhaoMovimento : MonoBehaviour
{   
    Rigidbody2D righ;
    
    Vector2 mousePos;

    public Camera cam;

    [SerializeField]
    private Transform Tanque;

    void Awake()
    {
        righ = GetComponent<Rigidbody2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.position = Tanque.transform.position;        

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);      
    }
    void FixedUpdate()
    {
        Vector2 OlharDirecao = mousePos - righ.position;

        float angle = Mathf.Atan2(OlharDirecao.y,OlharDirecao.x) * Mathf.Rad2Deg-90f;
        
        righ.rotation = angle; 
    }
}
