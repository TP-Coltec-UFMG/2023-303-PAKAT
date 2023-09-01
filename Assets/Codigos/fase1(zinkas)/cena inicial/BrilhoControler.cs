using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrilhoControler : MonoBehaviour
{
     public Slider brilho;
     public RawImage fundoPreto;

    public void alterarBrilho(){
       Color novarCor = new Color(0,0,0, brilho.value);
        fundoPreto.GetComponent<RawImage>().color = novarCor;
        RenderSettings.ambientLight = Color.Lerp(Color.black,Color.white,brilho.value);
        Debug.Log("brilho =" + brilho.value);
    }
    
}
