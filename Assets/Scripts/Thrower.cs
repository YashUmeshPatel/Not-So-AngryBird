using System;
using UnityEngine;

public class Thrower : MonoBehaviour
{    
    private void OnEnable()
    {
        InputController.OnDragEvent += Pull;
        InputController.OnDragEvent += Throw;
    }

    private void Throw()
    {
        throw new NotImplementedException();
    }

    private void Pull()
    {
        throw new NotImplementedException();
    }

    private void Load()
    {

    }

    private void Movement()
    {

    }
}
