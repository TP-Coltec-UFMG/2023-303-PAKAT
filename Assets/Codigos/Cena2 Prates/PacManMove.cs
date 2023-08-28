// Comment
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class PacManMove : MonoBehaviour
{

  private int totalItems;
  [SerializeField] private int collectedItems = 0;
  [SerializeField] private GameObject victoryScreen;
  public float speed = 0.4f;
  Vector2 dest = Vector2.zero;


  // Use this for initialization
  void Start()
  {
    totalItems = GameObject.FindGameObjectsWithTag("pacdot").Length;
    dest = transform.position;
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
    GetComponent<Rigidbody2D>().MovePosition(p);
    if (Input.GetKey("up"))
    {
      dest = (Vector2)transform.position + Vector2.up;
    }
    if (Input.GetKey(KeyCode.DownArrow))
    {
      dest = (Vector2)transform.position - Vector2.up;
    }
    if (Input.GetKey(KeyCode.RightArrow))
    {
      dest = (Vector2)transform.position + Vector2.right;
    }
    if (Input.GetKey(KeyCode.LeftArrow))
    {
      dest = (Vector2)transform.position - Vector2.right;
    }
    Vector2 dir = dest - (Vector2)transform.position;
    GetComponent<Animator>().SetFloat("DirX", dir.x);
    GetComponent<Animator>().SetFloat("DirY", dir.y);
  }

  bool valid(Vector2 dir)
  {
    Vector2 pos = transform.position;
    RaycastHit2D hit = Physics2D.Linecast(pos + dir, pos);
    return (hit.collider == GetComponent<Collider2D>());
  }

  void OnTriggerEnter2D(Collider2D co)
  {
    if (co.gameObject.tag == "pacdot")
    {
      collectedItems++;
      Destroy(co.gameObject);

      // Verificar se todos os itens foram coletados
      if (collectedItems >= totalItems)
      {
        AllItemsCollected();
      }
    }
  }

  void AllItemsCollected()
  {
    victoryScreen.SetActive(true);
  }
}