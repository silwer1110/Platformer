using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class Crystal : MonoBehaviour
{
    public event UnityAction<Crystal> Deactivated;

    private void OnTriggerEnter2D(Collider2D collision)
    {      
        Deactivated?.Invoke(this);
    }

    public void SetSpawnPosition(Vector3 position)
    {
        transform.position = position;
    }
}