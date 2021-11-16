using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NuclearPowerPlantTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData) {
        Tooltip.ShowTooltip_Static("Nuclear Power Plant\n\nPower Generation: <color=#FFFC0A>5</color> per cycle\nEmission Generation: <color=#AE0000>0.6</color> per cycle\nPrice: <color=#00EFFF>$1,000,000</color>\n\n<size=80%>Nuclear power releases less radiation into the environment than any other major energy source. Second, nuclear power plants operate at much higher capacity factors than renewable energy sources\n\nFun fact: Nuclear power provides 52% of America's clean energy. In fact, Nuclear helps power 28 U.S. states.");
    }

    public void OnPointerExit(PointerEventData eventData) {
        Tooltip.HideTooltip_Static();
    }
}
