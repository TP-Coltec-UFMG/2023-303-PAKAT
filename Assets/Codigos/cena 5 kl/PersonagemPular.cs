using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonagemPular : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool canJump = true;
    private Rigidbody2D rb;
    [SerializeField] GameObject GameOver;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public void ProximaCena(string nome)
    {
        SceneManager.LoadScene(nome);
    }
    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        canJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("barreira"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("obstaculo"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("vitoria"))
        {
            SceneManager.LoadScene("CenaFinal");
        }

    }

}