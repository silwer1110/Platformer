using System.Collections;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;

    public IEnumerator MoveToTarget(Vector3 target)
    {
        float distanceBetweenPoints = 0.01f;

        while ((transform.position - target).sqrMagnitude > distanceBetweenPoints)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, _speed * Time.deltaTime);

            yield return null;
        }

        transform.position = target;
    }
}