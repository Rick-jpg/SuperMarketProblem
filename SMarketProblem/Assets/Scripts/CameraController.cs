using Unity.VisualScripting;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera _mainCamera;
    private Vector3 _cameraPositionTarget;
    private float _cameraSizeTarget;

    private void LateUpdate()
    {
        _mainCamera.transform.position = Vector3.MoveTowards(_mainCamera.transform.position, _cameraPositionTarget, Time.deltaTime);
        _mainCamera.orthographicSize = Mathf.MoveTowards(_mainCamera.orthographicSize, _cameraSizeTarget, Time.deltaTime);
    }

    public void ChangeCameraBounds(Bounds newBounds)
    {
        newBounds.Expand(2);

        var vertical = newBounds.size.y;
        var horizontal = newBounds.size.x * _mainCamera.pixelHeight / _mainCamera.pixelWidth;

        _cameraPositionTarget = newBounds.center + Vector3.back;
        _cameraSizeTarget = Mathf.Max(horizontal, vertical) * 0.5f;
    }
}
