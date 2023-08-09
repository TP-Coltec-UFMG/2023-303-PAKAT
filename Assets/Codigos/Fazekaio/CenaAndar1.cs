using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenaAndar1 : MonoBehaviour
{
    [SerializeField]
    private float velocidade;

    void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);
    }
}