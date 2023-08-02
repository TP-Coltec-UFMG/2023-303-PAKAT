using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverbarco : MonoBehaviour{
private Rigidbody2D player;
[SerializeField] private float speed;


void Start(){
player = GetComponent<Rigidbody2D>();
}
void Update(){
player.velocity = new Vector2(
    Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.deltaTime;
}
}
