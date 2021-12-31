using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInput : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    public float Horizontal => _horizontal;
    public float Vertical => _vertical;
    private bool _jumpInputed;
    public bool JumpInputed => _jumpInputed;

    public void CheckDirectionInput()
    {
        _horizontal = Input.GetAxisRaw("Horizontal");
        _vertical = Input.GetAxisRaw("Vertical");
    }
    public void CheckJumpInput()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _jumpInputed = true;
        }
        else _jumpInputed = false;
    }
}
