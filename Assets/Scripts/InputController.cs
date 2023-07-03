using System;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public static Action OnDragEvent;
    public static Action OnReleaseEvent;

    private void Drag()
    {
        OnDragEvent?.Invoke();
    }

    private void Release()
    {
        OnDragEvent?.Invoke();
    }
}
