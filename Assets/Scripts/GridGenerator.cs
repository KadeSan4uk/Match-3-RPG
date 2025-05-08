using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField]
    private float _heightGrid = 5f;
    [SerializeField]
    private float _widthGrid = 7f;

    [SerializeField]
    private List<GameObject> _tilePrefabs;

    [SerializeField]
    private float _tileSize = 1f;

    private void Start()
    {
        GenerateGrid();
    }

    private void GenerateGrid()
    {
        for (int x = 0; x < _widthGrid; x++)
        {
            for (int y = 0; y < _heightGrid; y++)
            {
                GameObject selectedPrefab = _tilePrefabs[Random.Range(0, _tilePrefabs.Count)];

                Vector2 position = new Vector2(x * _tileSize, y * _tileSize);
                GameObject tile = Instantiate(selectedPrefab, position, Quaternion.identity);
                tile.transform.parent = this.transform;
                tile.name = $"Tile {x},{y}";
            }
        }

        float gridWidth = _widthGrid * _tileSize;
        float gridHeight = _heightGrid * _tileSize;
        transform.position = new Vector2(-gridWidth / 2 + _tileSize / 2, -gridHeight / 2 + _tileSize / 2);
    }
}
