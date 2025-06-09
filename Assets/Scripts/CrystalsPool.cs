using UnityEngine;
using UnityEngine.Pool;

public class CrystalsPool : MonoBehaviour
{
    [SerializeField] private Crystal _prefab;

    private ObjectPool<Crystal> _crystals;
    private int _maxSize = 20;
    private readonly int _capacity = 10;

    private void Awake()
    {
        CreatePool();
    }

    public void CreatePool()
    {
        _crystals = new ObjectPool<Crystal>
            (
            createFunc: () => Instantiate(_prefab),
            actionOnGet: (cube) => cube.gameObject.SetActive(true),
            actionOnRelease: (cube) => cube.gameObject.SetActive(false),
            actionOnDestroy: (cube) => Destroy(cube.gameObject),
            defaultCapacity: _capacity,
            maxSize: _maxSize
            );
    }

    public Crystal GetCrystal()
    {
        return _crystals.Get();
    }

    public void ReleasCrustal(Crystal crystal)
    {
        _crystals.Release(crystal);
    } 
    
    public int GetActiveCrystalsCount()
    {
        return _crystals.CountActive;
    }
}