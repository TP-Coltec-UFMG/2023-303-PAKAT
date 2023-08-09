using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barreira : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D outro){
        Destroy(outro.gameObject);
    }
}
