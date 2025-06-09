using System.Collections;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private float _speed;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        Transform target;

        int currentIndex = 0;

        float distanceBetweenPoints = 0.01f;

        while (_waypoints.Length > 0)
        {
            target = _waypoints[currentIndex];

            while (Vector2.Distance(transform.position, target.position) > distanceBetweenPoints)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
                yield return null;
            }

            transform.position = target.position;

            currentIndex = (currentIndex + 1) % _waypoints.Length;
        }
    }
}