using UnityEngine;

public class Fliper : MonoBehaviour
{
    [SerializeField] private Transform _transform;

    public void Flip(float moveDirection)
    {
        Vector2 left = new(0f, 180f);
        Vector2 right = new(0f, 0f);

        if (moveDirection > 0)
            _transform.rotation = Quaternion.Euler(right);
        else if (moveDirection < 0)
            _transform.rotation = Quaternion.Euler(left);
    }
}