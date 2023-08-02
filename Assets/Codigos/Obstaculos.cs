using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
[SerializeField] private float velocidade = 5f;
[SerializeField] private float variacaoDaPosicaoY = 1;

    private void Awake(){
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update() {
        this.transform.Translate(Vector3.up * this.velocidade * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D outro){
        this.Destruir();
        Debug.Log("destruiu");
    }

    public void Destruir(){
        Destroy(this.gameObject);
    }
}