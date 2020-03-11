using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    [SerializeField]
    BarraDeHP hpBar;

    private int HPMax = 7;
    [SerializeField]
    private int hp;
    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;

            if (hp <= 0)
            {
                hp = 0;
            }
            else if (hp >= HPMax)
            {
                hp = HPMax;
            }

            hpBar.Counter = hp;
        }
    }

    private void Awake()
    {
        HP = HPMax;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            HP--;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            HP++;
        }
    }
}
