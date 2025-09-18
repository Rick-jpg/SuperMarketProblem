using UnityEngine;

public class GridSpace : MonoBehaviour
{
    [SerializeField] private GameObject _houseVisual;
    public Vector2Int Coordinates { get; private set; }

    public bool HasHouse { get; private set; }

    public void Init(int x, int y, bool hasHouse)
    {
        Coordinates = new Vector2Int(x, y);
        HasHouse = hasHouse;
        _houseVisual.SetActive(hasHouse);
    }

}
