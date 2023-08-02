using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrossel : MonoBehaviour {

    [SerializeField] private float velocidade; //declaração de velocidade sendo possível usar ele na unity 
    private float tamanhoDaImagem; //saber qual o tamanho da imagem do chão para saber quanto o chão tem que andar 
    private Vector3 posicaoInicial; //Vector 3 pq tem 3 posições 

    private void Awake() {
        this.posicaoInicial = this.transform.position; //pega a posição inicial 
        this.tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x; //coleta o tamanho da imagem que fica em size x de SpriteRenderer
        float escala = this.transform.localScale.x; //
        this.tamanhoDaImagem *= escala;
    }

    void Update() {
        float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoDaImagem);//multiplica a velocidade x o tempo para calcular o deslocamento time.time calcula o tempo desde o inicio do jogp math repeat serve para limitar o deslocamento para no máximo o tamanho do objeto, quando atinge o máximo volta para 0, o limite é o valor de this.tamanho da imagem 
        this.transform.position = this.posicaoInicial + Vector3.left * deslocamento; //movimenta o objeto, para a esquerda?? pega a posição inicial e soma ao deslocamento
    }
}