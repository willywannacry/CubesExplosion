using UnityEngine;

public class ExplosionCreater : MonoBehaviour
{
    [SerializeField] private float xForce = 20f;
    [SerializeField] private float yForce = 20f;
    [SerializeField] private float zForce = 20f;

    public void Explode(GameObject[] cubes)
    {
        foreach (var cube in cubes)
        {
            Rigidbody rb = cube.GetComponent<Rigidbody>();
            AddForce(rb);
        }
    }

    private void AddForce(Rigidbody rb)
    {
        rb.AddForce(xForce, yForce, zForce);
    }
}
