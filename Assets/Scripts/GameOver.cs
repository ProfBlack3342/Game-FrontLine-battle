using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOver : MonoBehaviour
{

    
    Vida vida_ref;
    
    //SpawnarArmadilhas spawnarArmadilhas_ref;
    //TanqueMovimento tanqueMovimento_ref;
    //CanhaoMovimento canhaoMovimento_ref;
    //SpriteRenderer spriteRenderer_ref;

   

    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        
        /*spawnarArmadilhas_ref = GetComponent<SpawnarArmadilhas>();
        tanqueMovimento_ref = GameObject.Find("Tanque").GetComponent<TanqueMovimento>();
        canhaoMovimento_ref = GameObject.Find("Canhao").GetComponent<CanhaoMovimento>();
        //spriteRenderer_ref = GameObject.Find("GameOver").GetComponent<SpriteRenderer>();*/
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
