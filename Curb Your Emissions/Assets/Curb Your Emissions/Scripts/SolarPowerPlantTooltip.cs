using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SolarPowerPlantTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData) {
        Tooltip.ShowTooltip_Static("Solar Power Plant\n\nPower Generation: <color=#FFFC0A>3</color> per cycle\nEmission Generation: <color=#AE0000>1.5</color> per cycle\nPrice: <color=#00EFFF>$100,000</color>\n\n<size=80%>Solar power generation might be one of the newest ways to generate power, it is not any where the most efficient nor most clean way to generate power.\n\nFun fact: Solar power plants at utility level produce 2 times more emission than hydropower, 4 times more emission than nuclear and wind power plants.");
    }

    public void OnPointerExit(PointerEventData eventData) {
        Tooltip.HideTooltip_Static();
    }
}
