using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SpawnarMunicao : MonoBehaviour
{
    public GameObject municaoPrefab;

    public List<GameObject> Listmunicao = new List<GameObject>();
    [SerializeField]
    private Transform LinhaDeSpawnMuni1;
    [SerializeField]
    private Transform LinhaDeSpawnMuni2;
    [SerializeField]
    private Transform LinhaDeSpawnMuni3;
    [SerializeField]
    private Transform LinhaDeSpawnMuni4;

    [SerializeField]
    private float spawnarMuniInicial;

    [SerializeField]
    private float spawnarMuniMax;

    private int numero;

    // Update is called once per frame
    void Update()
    {
        spawnarMuniInicial += Time.deltaTime;
        if (spawnarMuniInicial >= spawnarMuniMax)
        {
            spawnarMuniInicial = 0;

            numero = Random.Range(1, 4);

            if (numero == 1)
            {
                Vector2 Position = LinhaDeSpawnMuni1.transform.position;

                SpawnMunicao(1, Random.Range(-1, 1), Position);
            }
            if (numero == 2)
            {
                Vector2 Position = LinhaDeSpawnMuni2.transform.position;

                SpawnMunicao(1, Random.Range(-1, 1), Position);
            }
            if (numero == 3)
            {
                Vector2 Position = LinhaDeSpawnMuni3.transform.position;

                SpawnMunicao(1, Random.Range(3, -3), Position);
            }
            if (numero == 4)
            {
                Vector2 Position = LinhaDeSpawnMuni4.transform.position;

                SpawnMunicao(1, Random.Range(1, -1), Position);
            }            
        }       
    }
    public void SpawnMunicao(int QuantidadeMunicao, int DistanciaLinhaSpawn, Vector2 Munipos)
    {
        Vector2 Position = Munipos;
        Position.y = DistanciaLinhaSpawn;

        for(int i = 0; i < QuantidadeMunicao; i++)
        {
            if (Listmunicao.Count > 0)
            {
                if (Listmunicao.OfType<Municao>().Any())
                {
                    int lugar = Listmunicao.FindLastIndex(x => x.GetType() == typeof(Municao));
                    GameObject muni = Listmunicao[lugar];
                    Listmunicao.RemoveAt(lugar);

                    muni.transform.position = Position;
                    muni.SetActive(true);
                }
            }
            else
            {
                Municao GameObject = Instantiate(municaoPrefab, Position, Quaternion.identity).GetComponent<Municao>();
            }
        }
    }
}
