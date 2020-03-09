using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomba : MonoBehaviour
{
    public int DanoDaBomba;
    VidaFilled vidaFilled_ref;
    SpawnarArmadilhas spawnarArmadilhas_ref;
   
    
    void Start()
    {
        
    }
    private void Awake()
    {
        vidaFilled_ref = GameObject.Find("Tanque").GetComponent<VidaFilled>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Tanque")
        {
            if (vidaFilled_ref.VidaAtual > 0)
            {
                vidaFilled_ref.VidaAtual -= DanoDaBomba;
                spawnarArmadilhas_ref.AdicionarOuDestruirArmadilhas(gameObject);
            }
        }
    }

}
