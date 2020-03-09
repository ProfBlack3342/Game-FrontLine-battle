using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Linq;

public class SpawnarArmadilhas : MonoBehaviour
{
    public GameObject MinaTerrestrePrefab;
    public GameObject BombaPrefab;

    public List<GameObject> ListArmadilhas = new List<GameObject>();

    [SerializeField]
    private Transform LinhaDeSpawnTrap1;
    [SerializeField]
    private Transform LinhaDeSpawnTrap2;
    [SerializeField]
    private Transform LinhaDeSpawnTrap3;
    [SerializeField]
    private Transform LinhaDeSpawnTrap4;

    [SerializeField]
    private float spawnarTrapInicial;

    [SerializeField]
    private float spawnarTrapMax;

    private int numero;
    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnarTrapInicial += Time.deltaTime;
        if (spawnarTrapInicial >= spawnarTrapMax)
        {
            spawnarTrapInicial = 0;

            numero = Random.Range(1, 8);


            if (numero == 1)
            {
                Vector2 Position = LinhaDeSpawnTrap1.transform.position;

                SpawnArmadilhas<MinaTerrestre>(1, Random.Range(-1, 0), Position);
            }
            if (numero == 2)
            {
                Vector2 Position = LinhaDeSpawnTrap2.transform.position;

                SpawnArmadilhas<MinaTerrestre>(1, Random.Range(-3, 3), Position);
            }
            if (numero == 3)
            {
                Vector2 Position = LinhaDeSpawnTrap3.transform.position;

                SpawnArmadilhas<MinaTerrestre>(1, Random.Range(-1, 0), Position);
            }
            if (numero == 4)
            {
                Vector2 Position = LinhaDeSpawnTrap4.transform.position;

                SpawnArmadilhas<MinaTerrestre>(1, Random.Range(-2, 2), Position);
            }
            if (numero == 5)
            {
                Vector2 Position2 = LinhaDeSpawnTrap1.transform.position;

                SpawnArmadilhas<Bomba>(1, Random.Range(-1, 0), Position2);
            }
            if (numero == 6)
            {
                Vector2 Position2 = LinhaDeSpawnTrap2.transform.position;

                SpawnArmadilhas<Bomba>(1, Random.Range(-3, 3), Position2);
            }
            if (numero == 7)
            {
                Vector2 Position2 = LinhaDeSpawnTrap3.transform.position;

                SpawnArmadilhas<Bomba>(1, Random.Range(-1, 0), Position2);
            }
            if (numero == 8)
            {
                Vector2 Position2 = LinhaDeSpawnTrap4.transform.position;

                SpawnArmadilhas<Bomba>(1, Random.Range(-2, 2), Position2);
            }


        }

        
    }    
    public void SpawnArmadilhas<Y>(int quantidadeArmadilhas,int distanciaLinhaspawn, Vector2 Armpos)
    {
        Vector2 Position = Armpos;
        Position.x = distanciaLinhaspawn;

        for(int i = 0; i < quantidadeArmadilhas; i++)
        {
            if (ListArmadilhas.Count > 0)
            {
                if (typeof(Y) == typeof(MinaTerrestre))
                {
                    if (ListArmadilhas.OfType<MinaTerrestre>().Any())
                    {
                        int posicao = ListArmadilhas.FindLastIndex(x => x.GetType() == typeof(MinaTerrestre));
                        GameObject MinaTerrestre = ListArmadilhas[posicao];
                        ListArmadilhas.RemoveAt(posicao);

                        MinaTerrestre.transform.position = Position;
                        MinaTerrestre.SetActive(true);
                        
                    }
                }
                else if (typeof(Y) == typeof(Bomba))
                {
                    if (ListArmadilhas.OfType<Bomba>().Any())
                    {
                        int posicao = ListArmadilhas.FindLastIndex(x => x.GetType() == typeof(Bomba));
                        GameObject Bomba = ListArmadilhas[posicao];
                        ListArmadilhas.RemoveAt(posicao);

                        Bomba.transform.position = Position;
                        Bomba.SetActive(true);
                    }
                }


                
            }
            else
            {
                if (typeof(Y) == typeof(MinaTerrestre))
                {
                    MinaTerrestre GameObject = Instantiate(MinaTerrestrePrefab, Position, Quaternion.identity).GetComponent<MinaTerrestre>();
                }
                if (typeof(Y) == typeof(Bomba))
                {
                    Bomba GameObject = Instantiate(BombaPrefab, Position, Quaternion.identity).GetComponent<Bomba>(); 
                }
            }
        }
    }
    public void AdicionarOuDestruirArmadilhas(GameObject gameObject)
    {
        if (ListArmadilhas.Count > 0)
        {
            ListArmadilhas.Add(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
