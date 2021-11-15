using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EmissionBar : MonoBehaviour
{
    public Slider slider;

    public void SetMaxEmission(float emission) {
        slider.maxValue = emission;
        slider.value = 0f;
    }
    
    public void SetEmission(float emission) {
        slider.value = emission;
    }

}
