using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeHP : MonoBehaviour
{
    public Texture2D[] hpStages;
    private Texture2D currentSprite;

    public int counter;

    public Rect hpSprite;

    private void Awake()
    {
        counter = hpStages.Length -1;
        currentSprite = hpStages[counter];
    }

    private void OnGUI()
    {
        GUI.DrawTexture(hpSprite, currentSprite);
    }
}
