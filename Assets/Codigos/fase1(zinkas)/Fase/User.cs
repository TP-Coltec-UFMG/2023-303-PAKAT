using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class User : MonoBehaviour
{
    private Rigidbody2D player;
    [SerializeField] private float speed;

    //animador 
    [SerializeField] public AnimationController playerAnim;

    public static int fase = 1;

     private bool restartPlayer, win;
    public GameObject panelWin;
    public GameObject GameOver; 
    private GameObject inicialPos;
    private float alturaTela;

    private bool  isPausa;
    public GameObject pausaPainel; 
    public float posicaoHorizontalSaida; // Armazena a posição horizontal de saída
   
    

    void Start()
    {
        Time.timeScale = 1f;
        player = GetComponent<Rigidbody2D>();
        alturaTela = Camera.main.orthographicSize;
        inicialPos = GameObject.Find("inicialPos");
        win = false;
        
    }

    void Update()
    {
        if (!isPausa) {
        
            // Movimento do jogador
        float horizontalInput = Input.GetAxisRaw("Horizontal");
            player.velocity = new Vector2(horizontalInput, 0f) * speed * Time.deltaTime;
           
            if (horizontalInput > 0f) // Andando para a direita
                {
                    playerAnim.PlayAnimation("Direita");
                }
                else if (horizontalInput < 0f) // Andando para a esquerda
                {
                    // Ativar a animação de andar para a esquerda
                    playerAnim.PlayAnimation("Esquerda");
                }
                else{
                  playerAnim.PlayAnimation("Parado");  
                }
             Restart();
            ProxFase();   
                    
                

            
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
 /* private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("armadilha")==true) {
            restartPlayer = true;
            Debug.Log("armadilha");
        }
        if (col.CompareTag("vitoria")==true) {
            win = true;
            Debug.Log(" vitoria");
        }
    }*/
private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("armadilha"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("vitoria"))
        {
            win = true;
            Debug.Log(" vitoria");

        }

    }
 
    private void Restart() {
        if (restartPlayer == true) {
            player.transform.position = new Vector2(inicialPos.transform.position.x, inicialPos.transform.position.y);
            GameOver.SetActive(true);
            Time.timeScale = 0;
            restartPlayer = false;
        }
    }

    private void ProxFase () {
        if (win == true) {
            player.velocity = new Vector2(0, player.velocity.y);
            panelWin.SetActive(true);
            Time.timeScale = 0;
            win = false;
            //panelWin.transform.position = Vector2.MoveTowards(panelwin.transform.position, cameraPos.transform.position, speedwin * Time.deltaTime);
            if (SceneManager.GetActiveScene().buildIndex> fase) {
                fase = SceneManager.GetActiveScene().buildIndex;
                PlayerPrefs.Save();
            }
        }
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
    
    /*  public bool EstaoPressionandoTeclaBaixo() {
        return pressionandoTeclaBaixo;
    }*/
