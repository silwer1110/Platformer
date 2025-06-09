using UnityEngine;

public class AnimationHandel : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
 
    public void AnimateRun(float direction, float speed)
    {
        _animator.SetFloat(PlayerAnimatorData.Params.Speed, Mathf.Abs(direction * speed));

        Flip(direction);
    }

    private void Flip(float moveDirection)
    {
        if (moveDirection > 0)
            _spriteRenderer.flipX = false;
        else if (moveDirection < 0)
            _spriteRenderer.flipX = true;
    }
}