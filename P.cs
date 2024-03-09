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
            Debug.Log("Olá " + nomeDoTitular + ". Espero que esteja bem");
        }
    }
    void EncontrarPeloNumeroDaConta()
    {
        if (numeroDaConta != 0)
        {
            Debug.Log("Você é "+nomeDoTitular);
        }
    }
    void TrasaçaoEntreAsContas()
    {
        Debug.Log("Você irá transferir " + saldo + "R$");
    }
    void WallStreet()
    {
        Debug.Log("Seja bem vindo ao banco"+nomeDoTitular);
        Debug.Log("Sua conta é "+ numeroDaConta);
        Debug.Log("O seu saldo atual é de " + saldo + "R$");

    }
}
