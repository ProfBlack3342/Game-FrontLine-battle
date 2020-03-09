using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinaTerrestre : MonoBehaviour
{
    //[SerializeField]
    //MinaTerrestre minaTerrestre_ref;

    VidaFilled vidaFilled_ref;
    public int DanoDaMina;
    SpawnarArmadilhas spawnarArmadilhas_ref;



    // Start is called before the first frame update
    private void Awake()
    {
        vidaFilled_ref = GameObject.Find("Tanque").GetComponent<VidaFilled>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Tanque")
        {
            if (vidaFilled_ref.VidaAtual > 0)
            {

                vidaFilled_ref.VidaAtual -= DanoDaMina;

                Debug.Log("Causou");

                spawnarArmadilhas_ref.AdicionarOuDestruirArmadilhas(gameObject);
            }
        }
    }

}
