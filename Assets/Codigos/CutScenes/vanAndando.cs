using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vanAndando : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private GameObject imagemContinuar;
    
    void Start()
    {
        Time.timeScale = 1;
    }
  
    void Update()
    {
        this.transform.Translate(Vector3.right * this.velocidade * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D colisao){
        if(colisao.gameObject.tag == "barreira"){
            Time.timeScale = 0;
            this.imagemContinuar.SetActive(true);
        }
    }

    public void continuar(string nomedaCena){
        SceneManager.LoadScene(nomedaCena);
    }
}




