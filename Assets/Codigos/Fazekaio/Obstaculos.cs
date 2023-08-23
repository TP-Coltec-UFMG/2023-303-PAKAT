using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaculos : MonoBehaviour
{
    public string MenuFases = "MenuFases"; // Nome da cena do menu de fases

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("obstaculo"))
        {
            SceneManager.LoadScene(MenuFases);
        }
    }
}
