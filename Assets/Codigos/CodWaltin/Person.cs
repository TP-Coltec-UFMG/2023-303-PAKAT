using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movePlayer = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
    }
}
