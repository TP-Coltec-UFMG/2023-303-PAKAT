using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed;
    private bool restartPlayer;
    private GameObject inicialPos;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        inicialPos = GameObject.Find("inicialPos");
    }

    void Update()
    {
        print(restartPlayer);
        movePlayer = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
        Restart(); 
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("armadilha")==true) {
            restartPlayer = true;
        }
    }

    private void Restart() {
        if (restartPlayer == true) {
            player.transform.position = new Vector2(inicialPos.transform.position.x, inicialPos.transform.position.y
            );
            restartPlayer = false;
        }
    }
}
