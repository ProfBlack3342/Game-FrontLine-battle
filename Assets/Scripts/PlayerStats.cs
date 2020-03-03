using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    float movSpeed;

    float hp;

    float ammoMax;
    float ammoCurrent;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ammo") && ammoCurrent < ammoMax)
        {
            ammoCurrent++;
        }
    }
}
