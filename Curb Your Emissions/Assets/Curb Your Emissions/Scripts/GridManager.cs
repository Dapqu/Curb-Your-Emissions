using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class GridManager : MonoBehaviour
{
    public static int width = 18;
    public static int height =9;
    [SerializeField] private Tile tilePrefab;
 
    [SerializeField] private Transform cam;
    private static Dictionary <Vector2, Tile> tiles;
    void Start() {
        GenerateGrid();
    }
    void GenerateGrid() {
        tiles = new Dictionary<Vector2, Tile>();
        for (int i=0; i<width; i++) {
            for (int j=0; j<height; j++) {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(i + 1, j), Quaternion.identity);
                spawnedTile.name = $"Tile {i} {j}";
                var isOffset = (i%2 == 0 && j%2 == 1) || (i%2 == 1 && j%2 ==0);
                spawnedTile.Init(isOffset);   
                tiles[new Vector2(i,j)] = spawnedTile;
            }
        }

 
        cam.transform.position = new Vector3((float)width/2 -0.5f, (float)height/2 -0.5f, -100);
    }

    public static Tile GetTileAtPosition(Vector2 pos) {
        if (tiles.TryGetValue(pos, out var tile)) {
            return tile;
        }
        return null;
    }
    public static Tile GetCloseTile(Vector2 pos) {
        foreach (KeyValuePair<Vector2, Tile> entry in tiles) {
            if ((entry.Key.x - pos.x) < 100) {
                if ((entry.Key.y - entry.Key.y) < 100) {
                    return entry.Value;
                }
            }
        }
        return null;
    }
}
 
