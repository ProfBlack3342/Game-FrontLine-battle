using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOver : MonoBehaviour
{

    public event Action QuandoMorrer;
    VidaFilled vidaFilled_ref;

    private void Awake()
    {
        vidaFilled_ref = GameObject.Find("Tanque").GetComponent<VidaFilled>();
    }
    void Start()
    {
        if (vidaFilled_ref.VidaAtual == 0)
        {
           // QuandoMorrer += destivarClasses();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void destivarClasses()
    {

    }
}
