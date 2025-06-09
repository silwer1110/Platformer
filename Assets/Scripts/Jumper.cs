using UnityEngine;

[RequireComponent(typeof(Rigidbody2D), typeof(LayerMask))]
public class Jumper : MonoBehaviour
{
    private const string Jump = nameof(Jump);

    [SerializeField] private LayerMask _layerMask;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _jumpForce;

    public void ActionJump()
    {
        if (Input.GetButtonDown(Jump) && IsGrounded())
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
    }

    private bool IsGrounded()
    {
        float groundCheckDistance = 1.5f;

        return Physics2D.Raycast(transform.position, Vector2.down, groundCheckDistance, _layerMask);
    }
}