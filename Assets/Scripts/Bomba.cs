using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    float bombDmg = 2f;
    Vida vida_ref;
    SpawnarArmadilhas spawnarArmadilhas_ref;   
    
    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Tanque")
        {
            vida_ref.HP -= (int)bombDmg;

            spawnarArmadilhas_ref.AdicionarOuDestruirArmadilhas(gameObject);
        }
    }
}
