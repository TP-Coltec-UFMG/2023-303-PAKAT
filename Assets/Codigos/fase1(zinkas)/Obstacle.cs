using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float velocidade = 5f;

    private void Update()
    {
        this.transform.Translate(Vector3.up * this.velocidade * Time.deltaTime);

        // Verifique se o obstáculo saiu da tela e destrua-o
        if (this.transform.position.y > Camera.main.orthographicSize)
        {
            Destroy(this.gameObject);
        }
    }
}
