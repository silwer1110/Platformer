using System.Collections;
using UnityEngine;

public class CrystalsSpawner : MonoBehaviour
{
    [SerializeField] private CrystalsPool _crystals;
    [SerializeField] private Transform[] _spawnPositions;
    [SerializeField] private float _spawnDelay = 3f;

    private int _maxCrystlsCount = 4;
    private int _currentPositionIndex = 0;

    private void Awake()
    {
        _crystals.CreatePool();
    }

    private void Start()
    {
        StartCoroutine(SpawnLoop());
    }

    private IEnumerator SpawnLoop()
    {
        WaitForSeconds wait = new(_spawnDelay);

        while (enabled)
        {
            if (_crystals.GetActiveCrystalsCount() < _maxCrystlsCount)
                Init(_crystals.GetCrystal());

            yield return wait;
        }
    }

    private void Init(Crystal crystal)
    {
        crystal.Deactivated += ReturToPool;

        crystal.SetSpawnPosition(GetSpawnPosition());
    }

    private void ReturToPool(Crystal crystal)
    {
        _crystals.ReleasCrustal(crystal);

        crystal.Deactivated -= ReturToPool;
    }

    private Vector2 GetSpawnPosition()
    {
        _currentPositionIndex = (_currentPositionIndex + 1) % _spawnPositions.Length;

        return _spawnPositions[_currentPositionIndex].position;
    }
}