using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputController : MonoBehaviour
{    
    public delegate void OnDragDelegate(Vector2 position);
    public static event OnDragDelegate OnDragEvent;    

    public delegate void OnReleaseDelegate();
    public static event OnReleaseDelegate OnReleaseEvent;

    GameControls gameControls;

    private void Awake()
    {
        gameControls = new GameControls();        
    }

    private void OnEnable()
    {
        gameControls.Throwable.Enable();

        gameControls.Throwable.Pull.started += Drag;
        gameControls.Throwable.Pull.performed += Drag;
        //gameControls.Throwable.Pull.canceled += Drag;
    }

    private void OnDisable()
    {
        gameControls.Throwable.Disable();

        gameControls.Throwable.Pull.started -= Drag;
        gameControls.Throwable.Pull.performed -= Drag;
        //gameControls.Throwable.Pull.canceled -= Drag;
    }

    private void Drag(InputAction.CallbackContext context)
    {        
        //Debug.Log("Input received: "+ context.ReadValue<Vector2>());
        OnDragEvent?.Invoke(context.ReadValue<Vector2>());        
    }

    private void Release()
    {
        OnReleaseEvent?.Invoke();
    }
}
