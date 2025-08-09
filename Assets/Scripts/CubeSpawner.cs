using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    private int _minCubes = 2;
    private int _maxCubes = 6;
    private float _sizeDevider = 0.5f;

    public GameObject[] Spawn(GameObject gameObject)
    {
        int count = Random.Range(_minCubes, _maxCubes);
        GameObject[] cubes = new GameObject[count];

        for (int i = 0; i < count; i++)
        {
            GameObject clone = Copy(gameObject);
            cubes[i] = clone;
        }

        return cubes;
    }

    private GameObject Copy(GameObject gameObject)
    {
        GameObject clone = Instantiate(gameObject);
        clone.transform.localScale = gameObject.transform.localScale * _sizeDevider;
        return clone;
    }
}
