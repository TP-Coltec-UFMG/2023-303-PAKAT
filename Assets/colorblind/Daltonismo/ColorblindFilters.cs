using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ColorblindFilters : MonoBehaviour
{
    public CameraController cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main.GetComponent<CameraController>();
        
    }

    public void ativarNone() 
    {
        cam.filter.mode = ColorBlindMode.Normal;
    }
    public void ativarDeuteranotopia()
    {
        cam.filter.mode = ColorBlindMode.Deuteranopia;
    }
    public void ativarProtanopia()
    {
        cam.filter.mode = ColorBlindMode.Protanopia;
    }
    // Update is called once per frame
 

}
