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
        if (PlayerPrefs.HasKey("CameraFilterMode"))
        {
            // Recupere o valor salvo da PlayerPrefs e defina-o na câmera
            int filterMode = PlayerPrefs.GetInt("CameraFilterMode");
            if (filterMode == 0)
            {
                ativarNone();

            }else if (filterMode == 1)
            {
                ativarDeuteranotopia();
            
            }else if(filterMode == 2)
            {
                ativarProtanopia();

            }
        }

    }

    public void ativarNone() 
    {
        cam.filter.mode = ColorBlindMode.Normal;
        PlayerPrefs.SetInt("CameraFilterMode", 0);
        PlayerPrefs.Save();

    }
    public void ativarDeuteranotopia()
    {
        cam.filter.mode = ColorBlindMode.Deuteranopia;
        PlayerPrefs.SetInt("CameraFilterMode", 1);
        PlayerPrefs.Save();

    }
    public void ativarProtanopia()
    {
        cam.filter.mode = ColorBlindMode.Protanopia;
        PlayerPrefs.SetInt("CameraFilterMode", 2);
        PlayerPrefs.Save();

    }
    
 

}
