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
    private bool isPausa;
    public GameObject pausaPainel;

    private void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!isPausa)
        {
            if (canJump && Input.GetKeyDown(KeyCode.UpArrow))
            {
                Jump();
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseScreen();
        }
    }

    void PauseScreen()
    {

        if (isPausa)
        {
            isPausa = false;
            Time.timeScale = 1f;
            pausaPainel.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        else
        {
            isPausa = true;
            Time.timeScale = 0f;
            pausaPainel.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
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
        if (collision.gameObject.CompareTag("chao"))
        {
            canJump = true;
        }

        if (collision.gameObject.CompareTag("armadilha"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.gameObject.CompareTag("vitoria"))
        {
            SceneManager.LoadScene("CenaFinal");
            Time.timeScale = 0;
        }

    }

}