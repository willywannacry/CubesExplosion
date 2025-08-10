using UnityEngine;

public class ExplosionCreater : MonoBehaviour
{
    [SerializeField] private float xForce = 20f;
    [SerializeField] private float yForce = 20f;
    [SerializeField] private float zForce = 20f;

    public void Explode(Cube[] cubes)
    {
        foreach (var cube in cubes)
        {
            Rigidbody rb = cube.Rb;
            rb.AddForce(xForce, yForce, zForce);
        }
    }
}