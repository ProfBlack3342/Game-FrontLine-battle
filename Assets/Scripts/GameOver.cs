using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameOver : MonoBehaviour
{

    public event Action QuandoMorrer;
    Vida vida_ref;
    SpawnarMunicao spawnarMunicao_ref;
    SpawnarArmadilhas spawnarArmadilhas_ref;
    TanqueMovimento tanqueMovimento_ref;
    CanhaoMovimento canhaoMovimento_ref;
    //SpriteRenderer spriteRenderer_ref;

    public GameObject Gameover;

    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        spawnarMunicao_ref = GetComponent<SpawnarMunicao>();
        spawnarArmadilhas_ref = GetComponent<SpawnarArmadilhas>();
        tanqueMovimento_ref = GameObject.Find("Tanque").GetComponent<TanqueMovimento>();
        canhaoMovimento_ref = GameObject.Find("Canhao").GetComponent<CanhaoMovimento>();
        //spriteRenderer_ref = GameObject.Find("GameOver").GetComponent<SpriteRenderer>();
    }
    void Start()
    {
        QuandoMorrer += AtivarGameOver;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AtivarGameOver()
    {
        if (vida_ref.HP <= 0)
        {
            spawnarMunicao_ref.enabled = false;
            spawnarArmadilhas_ref.enabled = false;
            tanqueMovimento_ref.enabled = false;
            canhaoMovimento_ref.enabled = false;
            Gameover.SetActive(true);
        }        
    }
}
