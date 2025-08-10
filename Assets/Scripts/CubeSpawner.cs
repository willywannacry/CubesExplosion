using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private int _minCubes = 2;
    private int _maxCubes = 6;
    private float _sizeDevider = 0.5f;

    public Cube[] TrySplitCube(Cube cube, float chance)
    {
        int quantity = Quantity();
        Cube[] cubes = new Cube[quantity];

        for (int i = 0; i < quantity; i++)
        {
            Cube clone = Copy(cube, chance);
            cubes[i] = clone;
        }

        Destroy(cube.gameObject);
        return cubes;
    }

    private int Quantity()
    {
        return Random.Range(_minCubes, _maxCubes);
    }

    private Cube Copy(Cube cube, float chance)
    {
        Cube clone = Instantiate(cube);
        clone.Init(cube.transform.localScale, chance, _sizeDevider);
        return clone;
    }
}