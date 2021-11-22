using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public GameObject parent;
    public GameManager gameManager;
    void Awake() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        parent = GameObject.Find("/Canvas/PowerPlants");
    }

    public void OnDrop(PointerEventData eventData) {
        Debug.Log("OnDrop");
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().localScale = GetComponent<RectTransform>().localScale;

            if (eventData.pointerDrag == parent.transform.GetChild(0).gameObject) {
                gameManager.ChangePowerPerTick(1f);
                gameManager.ChangeEmissionPerTick(0.82f);
                gameManager.ChangeGold(1000f);
            }
            else if (eventData.pointerDrag == parent.transform.GetChild(1).gameObject) {
                gameManager.ChangePowerPerTick(2f);
                gameManager.ChangeEmissionPerTick(0.5f);
                gameManager.ChangeGold(2000f);
            }
            else if (eventData.pointerDrag == parent.transform.GetChild(2).gameObject) {
                gameManager.ChangePowerPerTick(1f);
                gameManager.ChangeEmissionPerTick(0.24f);
                gameManager.ChangeGold(1500f);
            }
            else if (eventData.pointerDrag == parent.transform.GetChild(3).gameObject) {
                gameManager.ChangePowerPerTick(5f);
                gameManager.ChangeEmissionPerTick(0.6f);
                gameManager.ChangeGold(1000000f);
            }
            else if (eventData.pointerDrag == parent.transform.GetChild(4).gameObject) {
                gameManager.ChangePowerPerTick(3f);
                gameManager.ChangeEmissionPerTick(1.5f);
                gameManager.ChangeGold(100000f);
            }
            else if (eventData.pointerDrag == parent.transform.GetChild(5).gameObject) {
                gameManager.ChangePowerPerTick(1f);
                gameManager.ChangeEmissionPerTick(0.1f);
                gameManager.ChangeGold(1000f);
            }
        }
    }
}
