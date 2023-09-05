using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dificuldade : MonoBehaviour
{
    
    public static float dific; 

    public void Facil() {
        dific = 1f;
    }
    public void Medio() {
        dific = 1.5f;
    }

    public void Dificil() {
        dific = 2f;
    }
}
