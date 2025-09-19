using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GridGenerator _gridGenerator;
    [SerializeField] private CameraController _cameraController;
    private void OnEnable()
    {
        EventsChannel.Generation.OnBoundsComplete += HandleChangeBounds;
    }
    private void OnDisable()
    {
        EventsChannel.Generation.OnBoundsComplete -= HandleChangeBounds;
    }

    private void HandleChangeBounds(Bounds bounds)
    {
        _cameraController.ChangeCameraBounds(bounds);
    }
}
