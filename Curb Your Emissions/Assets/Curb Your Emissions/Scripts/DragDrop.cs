using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DragDrop : MonoBehaviour
{
    public bool placed = false;
    private Vector2 _originalPosition;

    void Awake() {
        _originalPosition = transform.position;
    }

    void OnMouseDrag() {
        if (!placed)
            transform.position = GetMousePos();
    }

    void OnMouseUp() {
        Tile _tile = GridManager.GetCloseTile(transform.position);
        if (_tile != null) {
            transform.position = _tile.transform.position;
        }
        transform.position = _originalPosition; 
    }

    Vector3 GetMousePos() {
        var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        return mousePos;
    }
}
