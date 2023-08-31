using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;

public class PacManMove : MonoBehaviour
{ 
  public GameObject pausaPainel;

  [SerializeField] public AnimationControllerP PlayerAnim;

  [SerializeField] private Text score;
  private bool isPausa;
  private int totalItems;
  [SerializeField] private int missingItems = 16;
  [SerializeField] private int collectedItems = 0;
  [SerializeField] private GameObject victoryScreen;
  public float speed = 0.4f;
  Vector2 dest = Vector2.zero;


  void Start()
  {
    Time.timeScale = 1f;
    totalItems = GameObject.FindGameObjectsWithTag("pacdot").Length;
    dest = transform.position;
  }

  void FixedUpdate()
  {
    if (!isPausa)
    {
      Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
      GetComponent<Rigidbody2D>().MovePosition(p);
      if (Input.GetKey("up"))
      {
        dest = (Vector2)transform.position + Vector2.up; 
        PlayerAnim.PlayAnimation("PratesCima");
      }
      else if (Input.GetKey(KeyCode.DownArrow))
      {
        dest = (Vector2)transform.position - Vector2.up;
        PlayerAnim.PlayAnimation("PratesBaixo");
      }
      else if (Input.GetKey(KeyCode.RightArrow))
      {
        dest = (Vector2)transform.position + Vector2.right;
        PlayerAnim.PlayAnimation("PratesDir");
      }
      else if (Input.GetKey(KeyCode.LeftArrow))
      {
        dest = (Vector2)transform.position - Vector2.right;
        PlayerAnim.PlayAnimation("PratesEsq");
      }
      Vector2 dir = dest - (Vector2)transform.position;
      GetComponent<Animator>().SetFloat("DirX", dir.x);
      GetComponent<Animator>().SetFloat("DirY", dir.y);
    }

  }
  void Update() 
  {
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
      missingItems--;
      score.text = $"{missingItems}"; 

      if (collectedItems >= totalItems)
      {
        Cursor.lockState = CursorLockMode.None;
        victoryScreen.SetActive(true);
        Time.timeScale = 0;
      }
    }
  }
}

                