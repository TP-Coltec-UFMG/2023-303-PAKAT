using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProximaFase : MonoBehaviour
{
    public void loadScene(string nome) {
        SceneManager.LoadScene(nome);
    }
    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void nextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
