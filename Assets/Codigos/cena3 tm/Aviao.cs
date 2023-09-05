using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour {
    private Rigidbody2D fisica;
    [SerializeField] private float forca;
    private Diretor diretor;
    private Vector3 posicaoInicial;
    private bool  isPausa;
    public GameObject pausaPainel; 

    private void Start(){
        this.posicaoInicial = this.transform.position;
        this.fisica = this.GetComponent<Rigidbody2D>();
    }

  

    private void Update () { 
        if (!isPausa) {
        if(Input.GetButtonDown("Fire1")){
            this.Impulsionar();
        }
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            PauseScreen();
        } 

    }

    public void Reiniciar(){
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }

    private void Impulsionar(){
        this.fisica.velocity = Vector2.zero; //a gravidade se acumula no objeto quando está em baixo então ele não sobe muito e os cliks são inconstantes 
        this.fisica.AddForce(Vector2.up * this.forca,ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao){
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
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
}
