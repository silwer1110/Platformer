using UnityEngine;

[RequireComponent (typeof(Rigidbody2D))]
public class Collector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out Crystal crystal))
        {
            crystal.Deactivate();
        }
    }
}