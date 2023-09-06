using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour { 
    [SerializeField]
    private float velocidade;

    private Vector3 posicaoInicial;
    private float tamanhoRealDaImagem ;

    private void Awake() {
        this.posicaoInicial = this.transform.position;
        float tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.y;
        float escala = this.transform.localScale.y;
        this.tamanhoRealDaImagem = tamanhoDaImagem * escala;
        velocidade *= Dificuldade.dific;
    }


    void Update() {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoRealDaImagem);
        this.transform.position = this.posicaoInicial + Vector3.down * deslocamento;

    }
}