using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geraobst : MonoBehaviour {

    [SerializeField] private float /*tempoParaGerarHonda*/ tempoParaGerarArvore, tempoParaGerarPassaro, tempoParaGerarCacto;

    private float cronometro2, cronometro3, cronometro4 , cronometro5;
    [SerializeField] private GameObject cacto;
    [SerializeField] private GameObject arvore;
    [SerializeField] private GameObject passaro;
   // [SerializeField] private GameObject honda;

    private bool obstaculosProntos = false;
    private float tempoDecorrido = 1f; // Tempo total decorrido

    private void Awake() {
        cronometro2 = tempoParaGerarArvore;
        cronometro3 = tempoParaGerarPassaro;
        cronometro4 = tempoParaGerarCacto;
        //cronometro5 = tempoParaGerarHonda;

       // Gerar o primeiro obstáculo no início do código
       // GameObject.Instantiate(cacto, transform.position, Quaternion.identity);
       // GameObject.Instantiate(arvore, transform.position, Quaternion.identity);
    }

    private void Update() {
        if (!obstaculosProntos) {
            tempoDecorrido += Time.deltaTime; // Incrementa o tempo decorrido

            cronometro2 -= Time.deltaTime;
            cronometro3 -= Time.deltaTime;
            cronometro4 -= Time.deltaTime;
            //cronometro5 -= Time.deltaTime;

            if (cronometro2 < 0) {
                GameObject.Instantiate(arvore, transform.position, Quaternion.identity);
                cronometro2 = tempoParaGerarArvore;
            }
            if (cronometro3 < 0) {
                GameObject.Instantiate(passaro, transform.position, Quaternion.identity);
                cronometro3 = tempoParaGerarPassaro;
            }

            if (cronometro4 < 0) {
                GameObject.Instantiate(cacto, transform.position, Quaternion.identity);
                cronometro4 = tempoParaGerarCacto;
            }

            // Verifica se o tempo total decorrido é maior que 60 segundos (1 minuto)
            //if (cronometro5 < 0) {
            //    obstaculosProntos = true;
            //    GameObject.Instantiate(honda, transform.position, Quaternion.identity);
            //    cronometro5 = tempoParaGerarHonda;
            //}
        }
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destroy(outro.gameObject);
    }
}
