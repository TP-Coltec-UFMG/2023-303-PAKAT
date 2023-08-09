using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemPular : MonoBehaviour
{
    public float jumpForce = 10f;
    private bool canJump = true;
    private Rigidbody2D rb;

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

    private void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        canJump = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("chão"))
        {
            canJump = true;
        }

    }
    
   
}