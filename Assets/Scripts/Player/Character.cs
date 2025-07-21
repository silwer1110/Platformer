using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private Jumper _jumper;
    [SerializeField] private PlayerMover _mover;
    [SerializeField] private InputReader _inputReader;

    private void Update()
    {
        _jumper.Jump(_inputReader.JumpPressed);
        _mover.Move(_inputReader.MovmentInput);
    }
}