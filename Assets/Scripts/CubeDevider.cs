using UnityEngine;

public class CubeDevider : MonoBehaviour
{
    [SerializeField] private GameObject _cube;
    [SerializeField] private int _minCubes = 2;
    [SerializeField] private int _maxCubes = 6;

    public void TrySplit()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null)
        {
            SplitCubes();
        }
    }

    private void SplitCubes()
    {
        int cubesQuantity = Random.Range(_minCubes, _maxCubes +1);
        GameObject[] cubes = new GameObject[cubesQuantity];

        for (int i = 0; i < cubesQuantity; i++)
        {
            GameObject cube = CreateCopy();
            cubes[i] = cube;
        }

        foreach (var cube in cubes)
        {
            ExplositionCreater explositionCreater = cube.GetComponent<ExplositionCreater>();
            ColorChanger colorChanger = cube.GetComponent<ColorChanger>();

            if (explositionCreater != null)
            {
                explositionCreater.TryExplode();
            }

            if (colorChanger != null)
            {
                colorChanger.TryChangeColor();
            }
        }

        Destroy(gameObject);
    }

    private GameObject CreateCopy()
    {
        GameObject cube = Instantiate(_cube, gameObject.transform.position, gameObject.transform.rotation);
        cube.transform.localScale = gameObject.transform.localScale / 2;
        ChanceCounter childChanceCounter = cube.GetComponent<ChanceCounter>();
        ChanceCounter parentChanceCounter = gameObject.GetComponent<ChanceCounter>();

        if (childChanceCounter != null && parentChanceCounter != null)
        {
            childChanceCounter.SetChance(parentChanceCounter.GetChance() * parentChanceCounter.ChanceDevider);
        }
        return cube;
    }
}
