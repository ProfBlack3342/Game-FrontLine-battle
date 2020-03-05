using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarMunicao : MonoBehaviour
{
    [SerializeField]
    Municao municao;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ammo"))
        {
            municao.Ammo++;

            Destroy(collision.gameObject);
        }
    }
}
