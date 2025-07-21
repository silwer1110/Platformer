using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Crystal : MonoBehaviour
{
    public event UnityAction<Crystal> Deactivated;

    public void Deactivate()
    {
        Deactivated?.Invoke(this);
    }

    public void SetPosition(Vector3 position)
    {
        transform.position = position;
    }
}