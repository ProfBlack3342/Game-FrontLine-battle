using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class Municao : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI ammoText;

    [SerializeField]
    private int ammoMax;
    [SerializeField]
    private int ammo;
    public int Ammo
    {
        get
        {
            return ammo;
        }
        set
        {
            ammo = value;

            if (ammo <= 0)
            {
                ammo = 0;
            }
            else if (ammo >= ammoMax)
            {
                ammo = ammoMax;
            }

            ammoText.text = "" + ammo;
        }
    }
  

}

