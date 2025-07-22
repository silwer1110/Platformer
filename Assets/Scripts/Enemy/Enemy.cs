using UnityEngine;

[RequireComponent(typeof(EnemyMover), typeof(WayHendel))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Patruller _patrul;

    private void Start()
    {
        StartCoroutine(_patrul.MoveLoop());
    }
}