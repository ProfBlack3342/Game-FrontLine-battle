using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Vida : MonoBehaviour
{
    public event Action onDeath; 

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

                onDeath();
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
