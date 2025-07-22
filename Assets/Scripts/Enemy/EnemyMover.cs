using System.Collections;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private float _distanceBetweenPoints = 0.01f;

    public IEnumerator MoveToTarget(Vector3 target)
    {
        while ((transform.position - target).sqrMagnitude > _distanceBetweenPoints)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, _speed * Time.deltaTime);

            yield return null;
        }

        transform.position = target;
    }
}