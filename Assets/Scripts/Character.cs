using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Jumper _jumper;
    [SerializeField] private Mover _mover;

    private void Update()
    {
        _jumper.ActionJump();
        _mover.ActionMove();
    }
}
