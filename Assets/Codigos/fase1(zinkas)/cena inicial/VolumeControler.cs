using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControler : MonoBehaviour
{
    public Slider volumeSlider;
public void alterarVolume(){
    AudioListener.volume = volumeSlider.value;
    Debug.Log("volume =" + volumeSlider.value);
}
}
