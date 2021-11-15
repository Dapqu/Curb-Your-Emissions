using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public static Tooltip Instance {get; private set;}

    [SerializeField] private RectTransform canvasRectTransform;
    private RectTransform backgroundRectTransform;
    private TextMeshProUGUI textMeshPro;
    private RectTransform rectTransform;

    void Awake() {
        Instance = this;

        backgroundRectTransform = transform.Find("Background").GetComponent<RectTransform>();
        textMeshPro = transform.Find("TooltipText").GetComponent<TextMeshProUGUI>();
        rectTransform = transform.GetComponent<RectTransform>();

        HideTooltip();
    }

    void SetText(string tooltipText) {
        textMeshPro.SetText(tooltipText);
        textMeshPro.ForceMeshUpdate();
    
        Vector2 textSize = textMeshPro.GetRenderedValues(false);
        Vector2 paddingSize = new Vector2(8, 8);
        backgroundRectTransform.sizeDelta = textSize + paddingSize;
    }

    void Update() {
        if (Input.GetMouseButton(0)) {
            HideTooltip();
        }
        Vector2 anchoredPosition = Input.mousePosition / canvasRectTransform.localScale.x;

        if (anchoredPosition.x + backgroundRectTransform.rect.width > canvasRectTransform.rect.width) {
            anchoredPosition.x = canvasRectTransform.rect.width - backgroundRectTransform.rect.width;
        }
        if (anchoredPosition.y + backgroundRectTransform.rect.height > canvasRectTransform.rect.height) {
            anchoredPosition.y = canvasRectTransform.rect.height - backgroundRectTransform.rect.height;
        }
        if (anchoredPosition.x < 0) {
            anchoredPosition.x = 0;
        }
        if (anchoredPosition.y < 0) {
            anchoredPosition.y = 0;
        }
        
        rectTransform.anchoredPosition = anchoredPosition;
    }

    void ShowTooltip(string tooltipText) {
        gameObject.SetActive(true);
        SetText(tooltipText);
    }

    void HideTooltip() {
        gameObject.SetActive(false);
    }

    public static void ShowTooltip_Static(string tooltipText) {
        Instance.ShowTooltip(tooltipText);
    }

    public static void HideTooltip_Static() {
        Instance.HideTooltip();
    }
}
