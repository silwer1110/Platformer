using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Jumper _jumper;
    [SerializeField] private Mover _mover;
    [SerializeField] private InputReader _inputReader;

    private void Update()
    {
        _jumper.ActionJump(_inputReader.JumpPressed);
        _mover.ActionMove(_inputReader.MovmentInput);
    }
}
