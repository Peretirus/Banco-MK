using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContaBancaria
{
    public string nomeDoTitular;
    public int numeroDaConta;
    public int saldo;


    void CriarContaBancaria(string _nomeDoTitular, int _numeroDaConta, int _saldo)
    {

        nomeDoTitular = _nomeDoTitular;
        numeroDaConta = _numeroDaConta;
        saldo = _saldo;


    }
    void EncontrarPeloNome()
    {
        if (nomeDoTitular != null)
        {
            Debug.Log("Ol� " + nomeDoTitular + ". Espero que esteja bem");
        }
    }
    void EncontrarPeloNumeroDaConta()
    {
        if (numeroDaConta != 0)
        {
            Debug.Log("Voc� � "+nomeDoTitular);
        }
    }
    void Trasa�aoEntreAsContas()
    {
        Debug.Log("Voc� ir� transferir " + saldo + "R$");
    }
    void WallStreet()
    {
        Debug.Log("Seja bem vindo ao banco"+nomeDoTitular);
        Debug.Log("Sua conta � "+ numeroDaConta);
        Debug.Log("O seu saldo atual � de " + saldo + "R$");

    }
}
