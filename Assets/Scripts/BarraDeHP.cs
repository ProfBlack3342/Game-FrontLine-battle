using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeHP : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite[] hpSprites;

    private int counter;
    public int Counter
    {
        get
        {
            return counter;
        }
        set
        {
            counter = value;

            spriteRenderer.sprite = hpSprites[counter];
        }
    }

    private void Awake()
    {
        Counter = hpSprites.Length -1;
    }
}
