using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanAndando : MonoBehaviour
{
    [SerializeField] private float velocidade;
    
    void Start()
    {
        
    }

  
    void Update()
    {
         this.transform.Translate(Vector3.right * this.velocidade * Time.deltaTime);
    }

}




