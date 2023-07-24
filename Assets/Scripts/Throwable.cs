using UnityEngine;

public class Throwable : MonoBehaviour
{
    public Rigidbody2D _rigidbody;

    public static bool isDragable;

    void Throw()
    {

    }

    void Load()
    {

    }

    void ApplyAbility()
    {

    }

    private void OnMouseEnter()
    {
        isDragable = true;
    }

    private void OnMouseExit()
    {
        isDragable = false;
    }
}
