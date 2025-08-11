using UnityEngine;

public class CubeHandler : MonoBehaviour
{
    [SerializeField] private InputReader _reader;
    [SerializeField] private CubeSpawner _spawner;
    [SerializeField] private ExplosionCreater _explosionCreater;
    [SerializeField] private ChanceCounter _chanceCounter;
    

    private void OnEnable()
    {
        _reader.CubeChosen += Divide;
    }

    private void OnDisable()
    {
        _reader.CubeChosen -= Divide;
    }

    private void Divide(Cube cube)
    {
        float chance = cube.Chance;
        bool wasSuccess = _chanceCounter.Roll(chance);

        if (wasSuccess)
        {
            float childChance = _chanceCounter.NewChance(cube);
            Cube[] cubes = _spawner.SplitCube(cube, childChance);
            _explosionCreater.Explode(cubes);
        }
        else
        {
            _spawner.Destroy(cube);
        }
    }
}