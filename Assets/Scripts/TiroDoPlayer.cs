using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class TiroDoPlayer : MonoBehaviour
{
    public List<GameObject> ListProjetil = new List<GameObject>();
    [SerializeField]
    Municao municao;

    public Rigidbody2D bullet;
    public Transform bulletExit;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && municao.Ammo > 0)
        {
            ShootAt();
        }     
    }

    void ShootAt()
    {
        if (ListProjetil.Count > 0)
        {
            if (ListProjetil.OfType<Projetil>().Any())
            {
                int posicao = ListProjetil.FindLastIndex(x => x.GetType() == typeof(Projetil));
                GameObject Projetil = ListProjetil[posicao];
                ListProjetil.RemoveAt(posicao);

                Projetil.transform.position = bulletExit.position;
                Projetil.SetActive(true);
                municao.Ammo--;
            }
        }
        else
        {
            Rigidbody2D bulletRgbd = Instantiate(bullet, bulletExit.position, bulletExit.rotation);

            municao.Ammo--;
        }

        
    }
    public void AdicionarOuDestruirProjetil(GameObject gameObject)
    {
        if (ListProjetil.Count > 0)
        {
            ListProjetil.Add(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
