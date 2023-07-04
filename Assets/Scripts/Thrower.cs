using System;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] Throwable _throwable;
    
    private void OnEnable()
    {
        InputController.OnDragEvent += Pull;
        InputController.OnDragEvent += Throw;
    }    

    private void Throw()
    {
        
    }

    private void Pull()
    {
        _throwable.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Load()
    {

    }

    private void Movement()
    {

    }
}
