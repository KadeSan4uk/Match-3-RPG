using System.Collections.Generic;
using UnityEngine;

public class GridCoordinate : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> _line1;
    [SerializeField]
    private List<GameObject> _line2;
    [SerializeField]
    private List<GameObject> _line3;
    [SerializeField]
    private List<GameObject> _line4;
    [SerializeField]
    private List<GameObject> _line5;
    [SerializeField]
    private List<GameObject> _line6;
    [SerializeField]
    private List<GameObject> _line7;

    private List<List<GameObject>> _grid = new List<List<GameObject>>();


    private void Awake()
    {
        _grid.Add(_line1);
        _grid.Add(_line2);
        _grid.Add(_line3);
        _grid.Add(_line4);
        _grid.Add(_line5);
        _grid.Add(_line6);
        _grid.Add(_line7);
    }
}
