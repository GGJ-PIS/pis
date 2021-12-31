using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private KeyboardInput _keyboard;
    [SerializeField] private MouseInput _mouse;
    public MoveInput MoveInput;
    
    private void Update()
    {
        // KeyboardChecking();
        MoveInputChecking();
        MouseChecking();
    }

    private void MoveInputChecking()
    {
        MoveInput.CheckDirectionInput();
        MoveInput.CheckJumpInput();
    }
    private void KeyboardChecking()
    {
       
    } 
    private void MouseChecking()
    {
        _mouse.CheckButtonInput();
        _mouse.CheckMousePosition();
    }
}

