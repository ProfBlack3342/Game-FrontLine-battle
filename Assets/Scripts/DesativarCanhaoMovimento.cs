using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarCanhaoMovimento : MonoBehaviour
{
    CanhaoMovimento canhaoMovimento_ref;
    Vida vida_ref;
    public GameObject[] Player;

    private void Awake()
    {
        canhaoMovimento_ref = GameObject.Find("Canhao").GetComponent<CanhaoMovimento>();
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        vida_ref.OnDeath += DesligarCanhaoMovimento; 
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= DesligarCanhaoMovimento;
    }
    public void DesligarCanhaoMovimento()
    {
        if (Player.Length > 0)
        {
            for(int i=0; i< Player.Length; i++)
            {
                Player[i].GetComponent<CanhaoMovimento>().enabled = false;
            }
        }
    }

}
