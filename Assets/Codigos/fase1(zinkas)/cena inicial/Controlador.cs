using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controlador : MonoBehaviour
{
    [SerializeField] private string[] falas = new string[] {};
    private int i = 0;
    [SerializeField] private TextMeshProUGUI caixa;

    void Start()
    {
        MostrarProximaFala();
    }

    public void MudaFala()
    {
        MostrarProximaFala();
    }

    private void MostrarProximaFala()
    {
        if (i < falas.Length)
        {
            caixa.text = falas[i];
            i++;
            Debug.Log("clique");
        }
        else
        {
            Debug.LogWarning("Todas as falas foram exibidas.");
        }
    }
}
