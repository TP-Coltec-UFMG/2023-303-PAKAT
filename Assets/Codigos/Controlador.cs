using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controlador : MonoBehaviour
{
    [SerializeField] private string[] falas = new string[] {};
    int i = 0;
    [SerializeField] private TextMeshProUGUI caixa;

    void Start(){
        caixa.text = falas[i];
        i++;
    }
    public void MudaFala(){
        caixa.text = falas[i];
        i++;
        Debug.Log("clique");
    }
}
