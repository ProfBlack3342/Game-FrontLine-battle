using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaquinaDeStatus : MonoBehaviour
{
    public static MaquinaDeStatus Singleton;
    public StateJogo stateJogo = new StateJogo();
    public Pausado pausado = new Pausado("Pause");
    public DesPausado desPausado = new DesPausado("Despausado");

    

    private void Awake()
    {
        if(Singleton!=this && Singleton != null)
        {
            GameObject.Destroy(this);
        }
        else
        {
            Singleton = this;
        }
    }
    private void Start()
    {
        MaquinaDeStatus.Singleton.stateJogo.MudarState(Singleton.pausado);
        MaquinaDeStatus.Singleton.stateJogo.MudarState(Singleton.desPausado);
    }
    private void Update()
    {

    }

}


public abstract class JogoPausadoOuDespausado
{
    public string name;

    public virtual void executar()
    {

    }
}
public class StateJogo
{
    public JogoPausadoOuDespausado Stateatual;

    public void MudarState(JogoPausadoOuDespausado novoState)
    {
        Stateatual = novoState;
    }
    public void Executar()
    {
        Stateatual.executar();
    }
}
public class Pausado : JogoPausadoOuDespausado
{
    public Pausado(string novoState)
    {
        name = novoState;
    }
    public override void executar()
    {
      

    }


}
public class DesPausado:JogoPausadoOuDespausado
{
    public DesPausado(string novoState)
    {
        name = novoState;
    }
    public override void executar()
    {
        
    }
}

