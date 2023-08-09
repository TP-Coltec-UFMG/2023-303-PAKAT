using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    
    [SerializeField] private float tempoParaGerar1, tempoParaGerar2, tempoParaGerar3;

    private float cronometro2, cronometro3;
    [SerializeField] private GameObject arvoreE;
    [SerializeField] private GameObject arvoreC;
    [SerializeField] private GameObject poco;

    private bool obstaculosProntos = false;

    private void Awake() {
        cronometro2 = tempoParaGerar2;
        cronometro3 = tempoParaGerar3;

        // Gerar o primeiro obstáculo no início do código
        GameObject.Instantiate(arvoreE, transform.position, Quaternion.identity);
    }

    private void Update() {
        if (!obstaculosProntos) {
            cronometro2 -= Time.deltaTime;
            cronometro3 -= Time.deltaTime;

            if (cronometro2 < 0) {
                GameObject.Instantiate(arvoreC, transform.position, Quaternion.identity);
                cronometro2 = tempoParaGerar2;
            }
            if (cronometro3 < 0) {
                GameObject.Instantiate(poco, transform.position, Quaternion.identity);
                cronometro3 = tempoParaGerar3;
            }

            if (cronometro2 <= 0 && cronometro3 <= 0) {
                obstaculosProntos = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D outro) {
        Destroy(outro.gameObject);
    }
}
