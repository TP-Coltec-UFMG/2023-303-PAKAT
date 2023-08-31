using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float variacaoDaPosicaoXEsquerda = -29f; // Variação na posição horizontal
    [SerializeField] private float variacaoDaPosicaoXDireita = 4f;
    private User jogador; // Referência ao script do jogador
    private Camera mainCamera; // Referência à câmera que segue o jogador

    private void Start()
    {
        jogador = FindObjectOfType<User>();
        mainCamera = Camera.main; // Obtenha a referência à câmera principal

        // Defina a posição inicial do obstáculo com variação na horizontal
        Vector3 posicaoInicial = new Vector3(
            transform.position.x + Random.Range(variacaoDaPosicaoXEsquerda, variacaoDaPosicaoXDireita),
            transform.position.y,
            transform.position.z);
        transform.position = posicaoInicial;
    }

    private void Update()
    {
        bool jogadorEstaMovendo = Input.GetKey(KeyCode.DownArrow);
        if (jogadorEstaMovendo)
        {
            this.transform.Translate(Vector3.up * (this.velocidade *2) * Time.deltaTime);
        }
        else
        {
            this.transform.Translate(Vector3.up * (this.velocidade / 3) * Time.deltaTime);
        }

        // Verifique se o jogador atingiu a posição vertical de saída e destrua o obstáculo
        if (transform.position.y > 2 * (mainCamera.transform.position.y + mainCamera.orthographicSize))
        {
            Destroy(this.gameObject);
        }
    }
}


