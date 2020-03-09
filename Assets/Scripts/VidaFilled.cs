using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaFilled : MonoBehaviour
{
    public int VidaMax = 100;
    public int VidaAtual;
    

    Image image;


    private void Awake()
    {
        image = GameObject.Find("Barra").GetComponent<Image>();
    }

    void Start()
    {
        VidaAtual = VidaMax;
        
    }

    // Update is called once per frame
    void Update()
    {
        float Preenchimento = ((float)VidaAtual /(float) VidaMax)/1;
        image.fillAmount = Mathf.SmoothStep(image.fillAmount, Preenchimento, 15 * Time.deltaTime);//??

        
    }
}
