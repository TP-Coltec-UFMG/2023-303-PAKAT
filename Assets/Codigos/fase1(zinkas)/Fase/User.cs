using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float speed;

    private float alturaTela;
    private float limiteInferior = -5f; // Defina o limite inferior da tela
    private float limiteSuperior = 5f;
    public float posicaoHorizontalSaida; // Armazena a posição horizontal de saída
   
    

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
            pressionandoTeclaBaixo = Input.GetKey(KeyCode.DownArrow);
            EstaoPressionandoTeclaBaixo();

        // Verifique se o jogador atingiu o limite inferior da tela
         /* if (transform.position.y < limiteInferior)
        {
            posicaoHorizontalSaida = transform.position.x;

         

            // Reposicione o jogador para a posição de saída do mapa, com y ajustado para o topo da tela
            transform.position = new Vector3(posicaoHorizontalSaida, alturaTela, transform.position.z);
        }*/
    }
      public bool EstaoPressionandoTeclaBaixo() {
        return pressionandoTeclaBaixo;
    }
}



