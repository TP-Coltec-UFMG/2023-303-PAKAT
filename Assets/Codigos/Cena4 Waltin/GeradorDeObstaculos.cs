using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {

    [SerializeField] private float tempoParaGerar1, tempoParaGerar2, tempoParaGerar3, tempoParaGerar4;

    private float cronometro2, cronometro3, cronometro4;
    [SerializeField] private GameObject arvoreE;
    [SerializeField] private GameObject arvoreC;
    [SerializeField] private GameObject pedra;
    [SerializeField] private GameObject porteira;
    [SerializeField] private GameObject next;

    private bool obstaculosProntos = false;
    private float tempoDecorrido = 0f; // Tempo total decorrido

    private void Awake() {
        cronometro2 = tempoParaGerar2;
        cronometro3 = tempoParaGerar3;
        cronometro4 = tempoParaGerar4;

        // Gerar o primeiro obstáculo no início do código
        GameObject.Instantiate(arvoreE, transform.position, Quaternion.identity);
        //GameObject.Instantiate(porteira, transform.position, Quaternion.identity);
    }

    private void Update() {
        if (!obstaculosProntos) {
            tempoDecorrido += Time.deltaTime; // Incrementa o tempo decorrido

            cronometro2 -= Time.deltaTime;
            cronometro3 -= Time.deltaTime;
            cronometro4 -= Time.deltaTime;

            if (cronometro2 < 0) {
                GameObject.Instantiate(arvoreC, transform.position, Quaternion.identity);
                cronometro2 = tempoParaGerar2;
            }
            if (cronometro3 < 0) {
                GameObject.Instantiate(pedra, transform.position, Quaternion.identity);
                cronometro3 = tempoParaGerar3;
            }

            if (cronometro4 < 0) {
                GameObject.Instantiate(arvoreE, transform.position, Quaternion.identity);
                cronometro4 = tempoParaGerar4;
            }

            // Verifica se o tempo total decorrido é maior que 60 segundos (1 minuto)
            if (tempoDecorrido > 25f) {
                
                
            }
            if (tempoDecorrido > 26f) {
                obstaculosProntos = true;
                GameObject.Instantiate(porteira, transform.position, Quaternion.identity);
                GameObject.Instantiate(next, transform.position, Quaternion.identity);
            }
         }
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destroy(outro.gameObject);
    }
}
