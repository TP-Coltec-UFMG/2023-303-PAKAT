using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerarVitoria : MonoBehaviour
{
    [SerializeField] private float tempoParaGerarHonda;
    [SerializeField] private GameObject honda;
    private float cronometro5;
    private bool obstaculosProntos = false;
    private float tempoDecorrido = 1f;

    private void Awake() {
        cronometro5 = tempoParaGerarHonda; 
    }

    private void Update() {
        tempoDecorrido += Time.deltaTime;
        cronometro5 -= Time.deltaTime;
        if (!obstaculosProntos)
        {
            if (cronometro5 < 0)
            {
                obstaculosProntos = true;
                GameObject.Instantiate(honda, transform.position, Quaternion.identity);
                cronometro5 = tempoParaGerarHonda;
            }
        }
    }
}
