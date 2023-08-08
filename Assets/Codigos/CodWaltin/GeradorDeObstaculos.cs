using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorDeObstaculos : MonoBehaviour {
    
    [SerializeField] private float tempoParaGerar1, tempoParaGerar2, tempoParaGerar3;

    private float cronometro1, cronometro2, cronometro3;
    [SerializeField] private GameObject arvoreE;
    [SerializeField] private GameObject arvoreC;
    [SerializeField] private GameObject poco;

    private void Amake() {
        this.cronometro1 = this.tempoParaGerar1;
        this.cronometro2 = this.tempoParaGerar2;
        this.cronometro3 = this.tempoParaGerar3;
    }

    private void Update() {
        this.cronometro1 -= Time.deltaTime;
        this.cronometro2 -= Time.deltaTime;
        this.cronometro3 -= Time.deltaTime;


        if (this.cronometro1 < 0) {
            //gerar 
            GameObject.Instantiate(this.arvoreE, this.transform.position,
            Quaternion.identity);
            this.cronometro1 = this.tempoParaGerar1;

        }
        if (this.cronometro2 < 0) {
            //gerar 
            GameObject.Instantiate(this.arvoreC, this.transform.position,
            Quaternion.identity);
            this.cronometro2 = this.tempoParaGerar2;

        }
        if (this.cronometro3 < 0) {
            //gerar 
            GameObject.Instantiate(this.poco, this.transform.position,
            Quaternion.identity);
            this.cronometro3 = this.tempoParaGerar3;

        }
    }
}
