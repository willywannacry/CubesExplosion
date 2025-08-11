using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private int _minCubes = 2;
    private int _maxCubes = 6;
    private float _sizeDevider = 0.5f;

    public Cube[] SplitCube(Cube cube, float chance)
    {
        int quantity = GetQuantity();
        Cube[] cubes = new Cube[quantity];

        for (int i = 0; i < quantity; i++)
        {
            Cube clone = Copy(cube, chance);
            cubes[i] = clone;
        }

        Destroy(cube.gameObject);
        return cubes;
    }

    public void Destroy(Cube cube)
    {
        Destroy(cube.gameObject);
    }

    private int GetQuantity()
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