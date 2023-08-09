using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;

    private User jogador; // Referência ao script do jogador

    private void Start()
    {
        jogador = FindObjectOfType<User>();
    }

    private void Update()
    {
        this.transform.Translate(Vector3.up * this.velocidade * Time.deltaTime);

        // Verifique se o jogador atingiu a posição horizontal de saída e destrua o obstáculo
        if (transform.position.y > Camera.main.orthographicSize || Mathf.Abs(transform.position.x - jogador.posicaoHorizontalSaida) < 0.01f)
        {
            Destroy(this.gameObject);
        }
    }
}
