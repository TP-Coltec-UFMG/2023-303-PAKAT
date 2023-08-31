using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Person : MonoBehaviour
{
    private Rigidbody2D player;

    public AnimationControllerW playerAnim;


    private float movePlayer;
    public float speed, speedWin;
    private bool restartPlayer, win, isPausa;
    private GameObject inicialPos, cameraPos;
    public GameObject panelWin;
    public GameObject pausaPainel, GameOver; 
    public string cena; 

    void Start()
    {
        Time.timeScale = 1f; 
        player = GetComponent<Rigidbody2D>();
        
        inicialPos = GameObject.Find("inicialPos");
        win = false;
       
    }

    void Update()
    {
        if (!isPausa) {
            print(win);
            movePlayer = Input.GetAxis("Horizontal");
            player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
           
            if (movePlayer > 0f) // Andando para a direita
                {
                    playerAnim.PlayAnimation("WaltinDireita");
                }
                else if (movePlayer < 0f) // Andando para a esquerda
                {
                    // Ativar a animação de andar para a esquerda
                    playerAnim.PlayAnimation("WaltinEsquerda");
                }
                else{
                  playerAnim.PlayAnimation("WaltinParado");  
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

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("armadilha")==true) {
            restartPlayer = true;
        }
        if (col.CompareTag("Win")==true) {
            win = true;
        }
    }

    /*private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("armadilha"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }

    }*/
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
        }
    }
}
