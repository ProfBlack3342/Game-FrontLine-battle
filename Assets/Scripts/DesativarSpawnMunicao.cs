﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarSpawnMunicao : MonoBehaviour
{
    SpawnarMunicao spawnarMunicao_ref;
    Vida vida_ref;

    private void Awake()
    {
        spawnarMunicao_ref = GetComponent<SpawnarMunicao>();
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
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
        vida_ref.OnDeath += DesligarSpawnMunicao;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= DesligarSpawnMunicao;
    }
    public void DesligarSpawnMunicao()
    {
        spawnarMunicao_ref.enabled = false;
        Debug.Log("DesligarSpawnMunicao");
    }
}
