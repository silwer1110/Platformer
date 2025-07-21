using UnityEngine;

public class AnimationHandel : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private SpriteRenderer _spriteRenderer;
    [SerializeField] private Fliper _fliper;
 
    public void AnimateRun(float direction, float speed)
    {
        _animator.SetFloat(PlayerAnimatorData.Params.Speed, Mathf.Abs(direction * speed));

        _fliper.Flip(direction);
    }
}