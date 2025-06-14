using UnityEngine;

[RequireComponent (typeof(Rigidbody2D), typeof(AnimationHandel))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 5f;
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private AnimationHandel _animationHandel;

    public void ActionMove(float moveDirection)
    {
        _rigidbody.velocity = new Vector2(moveDirection * _moveSpeed, _rigidbody.velocity.y);

        _animationHandel.AnimateRun(moveDirection, _moveSpeed);
    }
}