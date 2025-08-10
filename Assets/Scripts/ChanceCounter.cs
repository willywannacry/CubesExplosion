using UnityEngine;

public class ChanceCounter : MonoBehaviour
{
    [SerializeField] private InputReader _reader;
    [SerializeField] private CubeSpawner _spawner;
    [SerializeField] private ExplosionCreater _explosionCreater;
    private float _minChance = 0;
    private float _maxChance = 100;
    private float _decrement = 0.5f;

    private void OnEnable()
    {
        _reader.CubeChosen += CountChance;
    }

    private void CountChance(Cube cube)
    {
        float chance = cube.Chance;
        bool wasSuccess = Roll(chance);

        if (wasSuccess)
        {
            float childChance = NewChance(cube);
            Cube[] cubes = _spawner.TrySplitCube(cube, childChance);
            _explosionCreater.Explode(cubes);
        }
        else
        {
            Destroy(cube.gameObject);
        }
    }

    private bool Roll(float chance)
    {
        float roll = Random.Range(_minChance, _maxChance);
        Debug.Log($"{roll} < {chance}");
        return roll < chance;
    }
    private float NewChance(Cube cube)
    {
        return cube.Chance * _decrement;
    }
}