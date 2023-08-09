using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public string cenaMenuFases = "menuFases"; // Nome da cena do menu de fases

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstaculo"))
        {
            SceneManager.LoadScene(Voltarfase5);
        }
    }
}
