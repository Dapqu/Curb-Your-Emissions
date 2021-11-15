using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeothermalPowerPlantTooltip : MonoBehaviour
{
    void OnMouseOver() {
        Tooltip.ShowTooltip_Static("Geothermal Power Plant\n\nPower Generation: <color=#FFFC0A>2</color> per cycle\nEmission Generation: <color=#AE0000>0.5</color> per cycle\nPrice: <color=#00EFFF>$2,000</color>\n\n<size=80%>Geothermal power plants do not burn fuel, therefore they release little to no amount of emission into the atmosphere\n\nFun fact: Geothermal power plants emit 97% less acid sulfur compounds and about 99% less CO2 than fossil fuel power plants.");
        Debug.Log("Coal Tooltip On!");
    }

    void OnMouseExit() {
        Tooltip.HideTooltip_Static();
        Debug.Log("Coal Tooltip Off!");
    } 
}
