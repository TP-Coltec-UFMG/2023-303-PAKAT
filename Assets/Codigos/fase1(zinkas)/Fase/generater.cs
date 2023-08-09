using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generater : MonoBehaviour
{
    [SerializeField] private float tempoParaGerar;
    [SerializeField] private GameObject prefabObstaculo;
    private float cronometro;

    private void Awake()
    {
        this.cronometro = this.tempoParaGerar;
    }

    void Update()
    {
        this.cronometro -= Time.deltaTime;
        if (this.cronometro < 0)
        {
            Vector3 posicaoSpawn = new Vector3(transform.position.x, -10, transform.position.z);
            GameObject novoObstaculo = GameObject.Instantiate(prefabObstaculo, posicaoSpawn, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;
        }
    }
}

