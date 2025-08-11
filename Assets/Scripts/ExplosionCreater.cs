using UnityEngine;

public class ExplosionCreater : MonoBehaviour
{
    [SerializeField] private float _xForce = 20f;
    [SerializeField] private float _yForce = 20f;
    [SerializeField] private float _zForce = 20f;

    public void Explode(Cube[] cubes)
    {
        foreach (var cube in cubes)
        {
            Rigidbody rb = cube.Rigidbody;
            rb.AddForce(_xForce, _yForce, _zForce);
        }
    }
}