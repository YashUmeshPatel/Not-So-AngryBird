using System;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    [SerializeField] Throwable throwable;    

    private void OnEnable()
    {
        InputController.OnDragEvent += Pull;
        InputController.OnReleaseEvent += Throw;        
    }    

    private void Throw()
    {
            
    }

    private void Pull(Vector2 position)
    {
        if (Throwable.isDragable)
        {
            Debug.Log("Pulling Throwable: " + Camera.main.ScreenToWorldPoint(position));
            throwable.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(position).x, Camera.main.ScreenToWorldPoint(position).y, 0);
        }
    }

    private void Load()
    {
        
    }

    private void Movement()
    {
        
    }

       
}
