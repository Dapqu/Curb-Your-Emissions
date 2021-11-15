using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydroelectricPowerPlantTooltip : MonoBehaviour
{
    void OnMouseOver() {
        Tooltip.ShowTooltip_Static("Hydro Power Plant\n\nPower Generation: <color=#FFFC0A>1</color> per cycle\nEmission Generation: <color=#AE0000>0.24</color> per cycle\nPrice: <color=#00EFFF>$1,500</color>\n\n<size=80%>Although hydropower do not directly emit air pollutants, these power plants' structure could effect the enviroment in other ways.\n\nFun fact: Hydropower is one of the oldest power sources on the planet, generating power when flowing water spins a wheel or turbine. It was used by farmers as far back as ancient Greece for mechanical tasks like grinding grain.");
        Debug.Log("Coal Tooltip On!");
    }

    void OnMouseExit() {
        Tooltip.HideTooltip_Static();
        Debug.Log("Coal Tooltip Off!");
    }
}
