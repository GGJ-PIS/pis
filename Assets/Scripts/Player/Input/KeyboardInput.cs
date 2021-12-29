using UnityEngine;
   
public class KeyboardInput : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    public float Horizontal => _horizontal;
    public float Vertical => _vertical;
    private bool _jumpInputed;
    public bool JumpInputed => _jumpInputed;
    
    private void CheckDirectionInput()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }
    private void CheckJumpInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jumpInputed = true;
        }
        else _jumpInputed = false;
    }
}
