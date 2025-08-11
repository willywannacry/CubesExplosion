using System;
using UnityEngine;

public class Raycaster : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    
    private Cube _cube;

    private float _maxDistance = 100;
    private Ray _ray;


    private void Update()
    {
        _ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawLine(_ray.origin, _ray.direction * _maxDistance);

        RaycastHit hit;

        if (Physics.Raycast(_ray, out hit, _maxDistance))
        { 
            Transform objectHit = hit.transform;
            GameObject go = objectHit.gameObject;

            if (go.TryGetComponent<Cube>(out Cube cube))
            {
                _cube = cube;
            }
        }
    }

    public Cube GetCube()
    {
        return _cube;
    }
}
