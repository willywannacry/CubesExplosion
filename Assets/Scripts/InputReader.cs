using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private Ray _ray;
    [SerializeField] private float _maxDistance;
    [SerializeField] private float _radius;

    private void Update()
    {
        _ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Debug.DrawRay(_ray.origin, _ray.direction * _maxDistance);


        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(_ray, out hit, Mathf.Infinity))
            {
                GameObject objectHit = hit.collider.gameObject;
                ChanceCounter chanceCounter = objectHit.GetComponent<ChanceCounter>();

                if (chanceCounter != null)
                {
                    chanceCounter.CheckChance();
                }
            }
        }
    }
}
