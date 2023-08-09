using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlador : MonoBehaviour
{
    string[] falas = new string[] {"1", "2", "3"};
    int i = 0;
    [SerializeField] private caixa;
    private TextMeshPro texto;

    void Start(){
        texto = caixa.GetComponent<TextMeshPro>();
    }
    public void MudaFala(){
        texto.
    }
}
