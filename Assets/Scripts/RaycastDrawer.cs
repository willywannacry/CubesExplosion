using UnityEngine;

public class RaycastDrawer : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    private Ray _ray;
    [SerializeField] private GameObject _gameObject;
    private float _maxDistance = 100;
    public GameObject GameObject => _gameObject;

    private void Update()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(_ray.origin, _ray.direction * _maxDistance);

        RaycastHit hit;

        if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
        {
            
            Transform objectHit = hit.transform;
            _gameObject = objectHit.gameObject;
        }
    }

}
