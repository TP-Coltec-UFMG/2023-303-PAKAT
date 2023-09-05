using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class levelManager : MonoBehaviour
{
    
    public Button[] botoes;
    
    private void Update() {
        for (int i=0;i<botoes.Length;i++) {
            if (i+5>PlayerPrefs.GetInt("faseCompletada")) {
                botoes[i].interactable = false;
            }
        }
    }

}
