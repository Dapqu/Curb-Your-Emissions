using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CoalPowerPlantTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData) {
        Debug.Log("OnPointerEnter");
        Tooltip.ShowTooltip_Static("Coal Power Plant\n\nPower Generation: <color=#FFFC0A>1</color> per cycle\nEmission Generation: <color=#AE0000>0.82</color> per cycle\nPrice: <color=#00EFFF>$1,000</color>\n\n<size=80%>The simplest way to procdue power, but also the worst way for the planet.\n\nFun fact: Coal-based power plants emit an average of nearly 1kg of CO2 per kwh.");

    }

    public void OnPointerExit(PointerEventData eventData) {
        Debug.Log("OnPointerExit");
        Tooltip.HideTooltip_Static();

    }
}
