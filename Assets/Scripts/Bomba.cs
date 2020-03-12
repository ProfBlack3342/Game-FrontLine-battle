using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    SpawnarArmadilhas spawnarArmadilhas_ref;   
    
    private void Awake()
    {
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        spawnarArmadilhas_ref.AdicionarOuDestruirArmadilhas(gameObject);
    }
}
