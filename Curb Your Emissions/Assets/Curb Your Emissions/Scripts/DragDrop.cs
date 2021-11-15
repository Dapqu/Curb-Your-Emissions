using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour {
    private Vector3 dragOffset;

    void OnMouseDown() {
        dragOffset = transform.position - GetMousePos();
    }

    void OnMouseDrag() {
        transform.position = GetMousePos() + dragOffset;  
    } 


    Vector3 GetMousePos() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
