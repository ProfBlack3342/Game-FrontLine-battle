using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Slider slider_hp;
    [SerializeField]
    private int HPMax;
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

                if (slider_hp && slider_hp != null)
                {
                    slider_hp.value = 0;
                }
            }
            else if(hp >= HPMax)
            {
                hp = HPMax;

                if(slider_hp && slider_hp != null)
                {
                    slider_hp.value = HPMax;
                }
            }
            else
            {
                if(slider_hp && slider_hp != null)
                {
                    slider_hp.value = (float)hp/(float)HPMax;
                }
            }            
        }
    }    
}
