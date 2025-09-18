using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField] private Grid _grid;
    [SerializeField] private GridSpacePool _pool;
    [Range(0, 10)]
    [SerializeField] private int _gridLength, _gridWidth;
    [Range(0, 10)]
    [SerializeField] private int _amountOfHouses;
    [Range(0, 5)]
    [SerializeField] private int _housesLength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int i = 0; i < _gridLength; i++)
        {
            for (int j = 0; j < _gridWidth; j++)
            {
                var worldSpace = _grid.GetCellCenterWorld(new Vector3Int(i, 0, j));
                GridSpace newSpace = _pool.GetGridSpace(i,j,worldSpace,false); //False is hardcoded, should change based on amount of Houses
            }
        }
    }
}
