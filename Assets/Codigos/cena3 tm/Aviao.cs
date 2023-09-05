using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    private Rigidbody2D player;
    [SerializeField] private float forca;
    //private Diretor diretor;
    //private Vector3 posicaoInicial;



    private bool restartPlayer, win;
    public GameObject panelWin;
    public GameObject GameOver; 
    private GameObject inicialPos;
    
    private bool  isPausa;
    public GameObject pausaPainel; 

    private void Start(){
        Time.timeScale = 1f;
        player = GetComponent<Rigidbody2D>();
        inicialPos = GameObject.Find("inicialPos");
        win = false;
    }

  

    private void Update () { 
        if (!isPausa) {
        if(Input.GetButtonDown("Fire1")){
            this.Impulsionar();
            Restart();
            ProxFase(); 
        }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseScreen();
        } 

    }


    private void Impulsionar(){
        this.player.velocity = Vector2.zero; //a gravidade se acumula no objeto quando está em baixo então ele não sobe muito e os cliks são inconstantes 
        this.player.AddForce(Vector2.up * this.forca,ForceMode2D.Impulse);
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
        }
    }
}
