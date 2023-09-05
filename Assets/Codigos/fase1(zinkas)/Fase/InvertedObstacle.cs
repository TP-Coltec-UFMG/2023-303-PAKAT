using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvertedObstacle : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;
   //meio eh o 12.9
    [SerializeField] private float variacaoDaPosicaoXEsquerda = -15.9f; // Variação na posição horizontal
    [SerializeField] private float variacaoDaPosicaoXDireita = 15.9f;

    private Camera mainCamera; // Referência à câmera que segue o jogador

    private void Start()
    {
        mainCamera = Camera.main; // Obtenha a referência à câmera principal

        // Define a posição inicial com variação na horizontal
        Vector3 posicaoInicial = new Vector3(
            transform.position.x + Random.Range(variacaoDaPosicaoXEsquerda, variacaoDaPosicaoXDireita),
            mainCamera.transform.position.y + mainCamera.orthographicSize + 3f, // Inicia acima da câmera
            transform.position.z);

        transform.position = posicaoInicial;
        velocidade *= Dificuldade.dific;
    }

    private void Update()
    {
        bool jogadorEstaMovendo = Input.GetKey(KeyCode.DownArrow);
        if (jogadorEstaMovendo)
        {
            transform.Translate(Vector3.down * (this.velocidade *2) * Time.deltaTime);
        }
        else
        {
            this.transform.Translate(Vector3.down * (this.velocidade / 3) * Time.deltaTime);
        }
        

        // Verifique se o obstáculo passou pela câmera duas vezes
        if (transform.position.y < mainCamera.transform.position.y - 2 * mainCamera.orthographicSize)
        {
            Destroy(gameObject);
        }
    }
}


