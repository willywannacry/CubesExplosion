using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    public event Action<Cube> CubeChosen;

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
            Cube cube = go.GetComponent<Cube>();

            if (Input.GetMouseButtonDown(0) && cube != null)
            {
               CubeChosen(cube);
            }
        }
    }
}