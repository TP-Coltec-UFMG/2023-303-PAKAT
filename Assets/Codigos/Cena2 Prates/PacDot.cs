using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PacDot : MonoBehaviour
{
    private int totalItems;
    private int collectedItems;

    void Start()
    {
        // Contar quantos itens existem no mapa
        totalItems = GameObject.FindGameObjectsWithTag("pacdot").Length;
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            Destroy(gameObject);
            collectedItems++;

            // Verificar se todos os itens foram coletados
            if (collectedItems >= totalItems)
            {
                AllItemsCollected();
            }
        }
    }

    void AllItemsCollected()
    {
        SceneManager.LoadScene("MenuFases");
    }
}