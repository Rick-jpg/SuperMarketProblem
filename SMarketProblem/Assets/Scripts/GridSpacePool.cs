using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridSpacePool : MonoBehaviour
{
    [SerializeField] private GridSpace _prefab;
    private Queue<GridSpace> _gridSpaces = new();

    public GridSpace GetGridSpace(int x, int y, Vector3 position, bool hasHouse)
    {
        GridSpace space;
        if( _gridSpaces.Count > 0)
        {
            space = _gridSpaces.Dequeue();
            space.gameObject.SetActive(true);

        }
        else
        {
            space = Instantiate(_prefab, position, Quaternion.identity);
        }
        space.Init(x,y,hasHouse);
        return space;
    }

    public void ReturnToPool(GridSpace space)
    {
        _gridSpaces.Enqueue(space);
        space.gameObject.SetActive(false);
    }
}
