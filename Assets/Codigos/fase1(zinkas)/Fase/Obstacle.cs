using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;

    private User jogador; // Referência ao script do jogador
    private Camera mainCamera; // Referência à câmera que segue o jogador

    private void Start()
    {
        jogador = FindObjectOfType<User>();
        mainCamera = Camera.main; // Obtenha a referência à câmera principal
    }

    private void Update()
    {
        
        bool jogadorEstaMovendo = Input.GetKey(KeyCode.DownArrow);
        if (jogadorEstaMovendo) {
            this.transform.Translate(Vector3.up * this.velocidade * Time.deltaTime);}
        else{
            this.transform.Translate(Vector3.up * this.velocidade/3 * Time.deltaTime);}

        // Verifique se o jogador atingiu a posição vertical de saída e destrua o obstáculo
        if (transform.position.y > 2*(mainCamera.transform.position.y + mainCamera.orthographicSize))
        
        {
            Destroy(this.gameObject);
        }
    }
}

