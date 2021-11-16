using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WindPowerPlantTooltip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData) {
        Tooltip.ShowTooltip_Static("Wind Power Plant\n\nPower Generation: <color=#FFFC0A>1</color> per cycle\nEmission Generation: <color=#AE0000>0.1</color> per cycle\nPrice: <color=#00EFFF>$1,000</color>\n\n<size=80%>One of the most clean way to produce power, along side with nuclear power generation (<b>Suprise!</b>), Although not as powerful as the nuclear power plants, it is definitely one of the best way for the planet.\n\nFun fact: The US has over 500 wind turbine manufacturing plants that produce a majority of our turbines and employ 73,000 people.");

    }

    public void OnPointerExit(PointerEventData eventData) {
        Tooltip.HideTooltip_Static();
    }
}
