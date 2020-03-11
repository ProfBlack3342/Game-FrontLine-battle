using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtivarBotaoBack : MonoBehaviour
{
    Vida vida_ref;
    public GameObject Botao;
    // Start is called before the first frame update
    private void Awake()
    {
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
        vida_ref.OnDeath += LigarBotaoDeRetornoProMenu;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath -= LigarBotaoDeRetornoProMenu;
    }
    public void LigarBotaoDeRetornoProMenu()
    {
        Botao.SetActive(true);
    }
}
