using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Projetil : MonoBehaviour
{
    [SerializeField]
    float speed = 25f;

    float timerSelfDestruct = 0;
    float timerSelfDestruct_Max = 5;

    private Rigidbody2D rgbd;

    SpawnarArmadilhas spawnarArmadilhas_ref;
    TiroDoPlayer tiroDoPlayer_ref;

    private void Awake()
    {
        rgbd = GetComponent<Rigidbody2D>();
        spawnarArmadilhas_ref = GameObject.Find("Game").GetComponent<SpawnarArmadilhas>();
        tiroDoPlayer_ref = GameObject.Find("Tanque").GetComponent<TiroDoPlayer>();

    }

    // Start is called before the first frame update
    void Start()
    {
        timerSelfDestruct = Time.time;

        //Define a velocidade do rigidbody como um vetor que aponta para frente, multiplicado ao valor de "speed"
        rgbd.velocity = transform.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timerSelfDestruct + timerSelfDestruct_Max)
        {
            tiroDoPlayer_ref.AdicionarOuDestruirProjetil(gameObject);

            timerSelfDestruct = Time.time;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Armadilha")
        {
            GameObject armadilha = collision.gameObject;
            spawnarArmadilhas_ref.AdicionarOuDestruirArmadilhas(armadilha);

            tiroDoPlayer_ref.AdicionarOuDestruirProjetil(gameObject);
        }
    }
}