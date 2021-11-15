using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoalPowerPlantTooltip : MonoBehaviour
{
    void OnMouseOver() {
        Tooltip.ShowTooltip_Static("Coal Power Plant\n\nPower Generation: <color=#FFFC0A>1</color> per cycle\nEmission Generation: <color=#AE0000>0.82</color> per cycle\nPrice: <color=#00EFFF>$1,000</color>\n\n<size=80%>The simplest way to procdue power, but also the worst way for the planet.\n\nFun fact: Coal-based power plants emit an average of nearly 1kg of CO2 per kwh.");
        Debug.Log("Coal Tooltip On!");
    }

    void OnMouseExit() {
        Tooltip.HideTooltip_Static();
        Debug.Log("Coal Tooltip Off!");
    }
}
