using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private CubeManager _cubeManager;
    [SerializeField] private Camera _camera;
    private float _maxDistance = 100;
    private Ray _ray;

    void Update()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(_ray.origin, _ray.direction * _maxDistance);

        RaycastHit hit;

        if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
        {
            Transform objectHit = hit.transform;
            GameObject cube = objectHit.gameObject;

            if (Input.GetMouseButtonDown(0) && objectHit.CompareTag("Cube"))
            {
                _cubeManager.TrySplit(cube);
            }
        }
    }
}