using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class user : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float speed;

    private float alturaTela;
    public float limiteInferior = -5f; // Defina o limite inferior da tela
    public Vector3 posicaoInicial; // Defina a posição inicial do jogador

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        alturaTela = Camera.main.orthographicSize;
    }

    void Update()
    {
        // Movimento do jogador
        player.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;

        // Verifique se o jogador atingiu o limite inferior da tela
        if (transform.position.y < limiteInferior)
        {
            // Reposicione o jogador para a posição inicial
            transform.position = posicaoInicial;
        }
    }
}
