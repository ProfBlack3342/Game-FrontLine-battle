using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorDeColisao : MonoBehaviour
{
    Vida vida_ref;
    float danoDeArmadilha = 1f;
    float danoDeProjetil = 2f;

    private void Awake()
    {
        vida_ref = GetComponent<Vida>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if (collision.gameObject.tag == "Armadilha")
        {
            vida_ref.HP -= (int)danoDeArmadilha;
        }

        if (collision.gameObject.tag == "Projetil")
        {
            vida_ref.HP -= (int)danoDeProjetil;
        }
    }
}
