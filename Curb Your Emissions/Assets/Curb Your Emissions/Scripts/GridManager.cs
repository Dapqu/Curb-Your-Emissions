using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GridManager : MonoBehaviour
{
    public static int width = 16;
    public static int height = 9;
 
    [SerializeField] private Tile tilePrefab;
 
    [SerializeField] private Transform cam;
 
    void Start() {
        GenerateGrid();
    }
 
    void GenerateGrid() {
        for (int i=0; i<width; i++) {
            for (int j=0; j<height; j++) {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(i, j), Quaternion.identity);
                spawnedTile.name = $"Tile {i} {j}";
 
                var isOffset = (i%2 == 0 && j%2 == 1) || (i%2 == 1 && j%2 ==0);
                spawnedTile.Init(isOffset);
            }
        }
 
        cam.transform.position = new Vector3((float)width/2 -0.5f, (float)height/2 -0.5f, -10);
    }
}
 
