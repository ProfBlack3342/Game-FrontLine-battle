using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarGameOver : MonoBehaviour
{
    Vida vida_ref;
    SpriteRenderer spriteRenderer_ref;
    // Start is called before the first frame update
    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        spriteRenderer_ref = GameObject.Find("GameOver").GetComponent<SpriteRenderer>();
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        vida_ref.OnDeath += AcionarGameOver;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= AcionarGameOver;
    }
    public void AcionarGameOver()
    {
        spriteRenderer_ref.enabled = true;
    }
}
