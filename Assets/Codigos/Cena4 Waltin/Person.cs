using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    private Rigidbody2D player;
    private float movePlayer;
    public float speed, alturaCamera, speedPorteira;
    private bool restartPlayer, porteira;
    private GameObject inicialPos, cameraPos;
    public GameObject panelVitoria;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        cameraPos = GameObject.Find("Main Camera");
        inicialPos = GameObject.Find("inicialPos");
        porteira = false;
    }

    void Update()
    {
        print(porteira);
        movePlayer = Input.GetAxis("Horizontal");
        cameraPos.transform.position = new Vector3(cameraPos.transform.position.x, player.transform.position.y+alturaCamera, cameraPos.transform.position.z);
        player.velocity = new Vector2(movePlayer * speed, player.velocity.y);
        Restart(); 
    }

    private void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("armadilha")==true) {
            restartPlayer = true;
        }
        if (col.CompareTag("vitoria")==true) {
            porteira = true;
        }
    }

    private void Restart() {
        if (restartPlayer == true) {
            player.transform.position = new Vector2(inicialPos.transform.position.x, inicialPos.transform.position.y);
            restartPlayer = false;
        }
    }

    private void ProxFase () {
        if (porteira==true) {
            player.velocity = new Vector2(0, player.velocity.y);
            panelVitoria.transform.position = Vector2.MoveTowards(panelVitoria.transform.position, cameraPos.transform.position, speedPorteira * Time.deltaTime);
        }
    }
}
