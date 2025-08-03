using UnityEngine;

public class ExplositionCreater : MonoBehaviour
{
    [SerializeField] private float xForce = 20;
    [SerializeField] private float yForce = 20;
    [SerializeField] private float zForce = 20;

    public void TryExplode()
    {
        Explode();
    }

    private void Explode()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (rb != null )
        {
            rb.AddForce(xForce, yForce, zForce);
        }
    }
}
