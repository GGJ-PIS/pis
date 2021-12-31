using UnityEngine;

public class MouseInput: MonoBehaviour
{
    private bool _inputedMouseButton0;
    public bool InputedMouseButton0 => _inputedMouseButton0;

    private bool _inputedMouseButton1;
    public bool InputedMouseButton1 => _inputedMouseButton1;

    private Vector3 _worldMousePosition;
    public Vector3 WorldMousePosition => _worldMousePosition;

    private Camera _mainCamera;
    private void Start()
    {
        _mainCamera = Camera.main;
    }
    public void CheckButtonInput()
    {
        if (Input.GetMouseButtonDown(0)) _inputedMouseButton0 = true;
        else _inputedMouseButton0 = false;
        if (Input.GetMouseButtonDown(1)) _inputedMouseButton1 = true;
        else _inputedMouseButton1 = false;
    }

    public void CheckMousePosition()
    {
        Vector3 screenMousePosition = Input.mousePosition;
        _worldMousePosition = _mainCamera.ScreenToWorldPoint(screenMousePosition);
    }
}
