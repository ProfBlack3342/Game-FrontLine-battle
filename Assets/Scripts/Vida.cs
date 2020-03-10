using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    BarraDeHP hpBar;

    private int HPMax;
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

            hpBar.counter = hp;
        }
    }

    private void Awake()
    {
        HPMax = hpBar.hpStages.Length;
    }
}
