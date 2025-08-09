using System;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    private GameObject _currentCube;
    private ChanceCounter _chanceCounter;
    private CubeSpawner _cubeSpawner;
    private ExplosionCreater _explosionCreater;
    private ColorChanger _colorChanger;
    private InputReader _inputReader;

    private void Awake()
    {
        _chanceCounter = GetComponent<ChanceCounter>();
        _cubeSpawner = GetComponent<CubeSpawner>();
        _explosionCreater = GetComponent<ExplosionCreater>();
        _colorChanger = GetComponent<ColorChanger>();
        _inputReader = GetComponent<InputReader>();
    }

    public void TrySplit(GameObject gameObject)
    {
        _currentCube = gameObject;
        CubeChance cube = _currentCube.GetComponent<CubeChance>();
        bool wasSuccess = _chanceCounter.CountChance(cube.Chance);

        if (wasSuccess)
        {
            GameObject[] cubes = _cubeSpawner.Spawn(_currentCube);
            _explosionCreater.Explode(cubes);
            _colorChanger.ChangeColor(cubes);
            _chanceCounter.ChangeChance(cubes);
            Destroy(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
