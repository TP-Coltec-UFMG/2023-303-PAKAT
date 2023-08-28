using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarrosselFundo : MonoBehaviour {

    [SerializeField] private float velocidade;
    private float tamanhoDaImagem;
    private Vector3 posicaoInicial;

    // Referência ao script do jogador
    public User user;

    private void Awake() {
        this.posicaoInicial = this.transform.position;
        this.tamanhoDaImagem = this.GetComponent<SpriteRenderer>().size.x;
        float escala = this.transform.localScale.x;
        this.tamanhoDaImagem *= escala;
    }

    void Update() {
        // Verifica se o jogador está pressionando a tecla de seta para baixo
        bool jogadorEstaMovendo = user.EstaoPressionandoTeclaBaixo();

        // Calcula o deslocamento apenas se o jogador estiver pressionando a tecla de seta para baixo
        if (jogadorEstaMovendo) {
            float deslocamento = Mathf.Repeat(this.velocidade * Time.time, this.tamanhoDaImagem);
            this.transform.position = this.posicaoInicial + Vector3.down * deslocamento;
        }
    }
}