using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarTiroDoplayer : MonoBehaviour
{
    TiroDoPlayer tiroDoPlayer_ref;
    Vida vida_ref;
    public GameObject[] Player;
    // Start is called before the first frame update

    private void Awake()
    {
        tiroDoPlayer_ref = GameObject.Find("Tanque").GetComponent<TiroDoPlayer>();
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
        vida_ref.OnDeath += DesligarTiroDoPlayer;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= DesligarTiroDoPlayer;
    }
    public void DesligarTiroDoPlayer()
    {
        if (Player.Length > 0)
        {
            for(int i=0; i < Player.Length; i++)
            {
                Player[i].GetComponent<TiroDoPlayer>().enabled = false;
            }
        }
    }

}
