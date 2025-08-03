using UnityEngine;

public class RaycastDrawer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private Ray _ray;
    [SerializeField] private float _maxDistance;
    [SerializeField] private float _radius;

    public Transform Object;

    private void Update()
    {
        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(_ray.origin, _ray.direction * _maxDistance);

        if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
        {
            Transform objectHit = hit.transform;
            Object = objectHit;
        }
    }
}
