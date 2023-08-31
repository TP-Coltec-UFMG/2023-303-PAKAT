using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float speed;

    //animador 
    [SerializeField] public AnimationController playerAnim;

    private float alturaTela;

    private bool  isPausa;
    public GameObject pausaPainel; 
    public float posicaoHorizontalSaida; // Armazena a posição horizontal de saída
   
    

    void Start()
    {
        
        player = GetComponent<Rigidbody2D>();
        alturaTela = Camera.main.orthographicSize;
    }

    void Update()
    {
        if (!isPausa) {
        
            // Movimento do jogador
        float horizontalInput = Input.GetAxisRaw("Horizontal");
            player.velocity = new Vector2(horizontalInput, 0f) * speed * Time.deltaTime;
           
            if (horizontalInput > 0f) // Andando para a direita
                {
                    playerAnim.PlayAnimation("andando");
                }
                else if (horizontalInput < 0f) // Andando para a esquerda
                {
                    // Ativar a animação de andar para a esquerda
                    playerAnim.PlayAnimation("esquerda");
                }
                else{
                  playerAnim.PlayAnimation("Parado");  
                }
                
                    
                

            
        }  
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseScreen();
        }    
           
}

void PauseScreen() {
        
        if (isPausa) {
            isPausa = false;
            Time.timeScale = 1f;
            pausaPainel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false; 
        }
        else {
            isPausa = true;
            Time.timeScale = 0f; 
            pausaPainel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
        }
    }

//pressionandoTeclaBaixo = Input.GetKey(KeyCode.DownArrow);
           // EstaoPressionandoTeclaBaixo(); 

        // Verifique se o jogador atingiu o limite inferior da tela
         /* if (transform.position.y < limiteInferior)
        {
            posicaoHorizontalSaida = transform.position.x;

         

            // Reposicione o jogador para a posição de saída do mapa, com y ajustado para o topo da tela
            transform.position = new Vector3(posicaoHorizontalSaida, alturaTela, transform.position.z);
        }*/
    }
    /*  public bool EstaoPressionandoTeclaBaixo() {
        return pressionandoTeclaBaixo;
    }*/
