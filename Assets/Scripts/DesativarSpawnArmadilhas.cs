using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesativarSpawnArmadilhas : MonoBehaviour
{
    Vida vida_ref;
    SpawnarArmadilhas spawnarArmadilhas_ref;

    private void Awake()
    {
        vida_ref = GameObject.Find("Tanque").GetComponent<Vida>();
        spawnarArmadilhas_ref = GetComponent<SpawnarArmadilhas>();
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
        vida_ref.OnDeath += DesligarSpawnArmadilha;
    }
    private void OnDisable()
    {
        vida_ref.OnDeath += DesligarSpawnArmadilha;
    }
    public void DesligarSpawnArmadilha()
    {
        spawnarArmadilhas_ref.enabled = false;
        Debug.Log("DesligarSpawnArmadilhas");
    }
}
