using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porteira: MonoBehaviour {
    [SerializeField] private float velocidade = 5f;
    [SerializeField] private float variacaoDaPosicaoX = 1;

    private void Awake(){
        this.transform.Translate(Vector3.left * 0);
    }

    private void Update() {
        this.transform.Translate(Vector3.down * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro){
        Debug.Log("Bateu em: " + outro.gameObject.tag);
        if(outro.gameObject.tag == "barreira")
            this.Destruir();
        // else if(outro.gameObject.tag == "Player")
        //     Destroy(outro.gameObject);
    }

    public void Destruir(){
        Destroy(this.gameObject);
    }
}