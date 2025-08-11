using System;
using UnityEngine;

public class InputReader : MonoBehaviour
{
    private Raycaster _raycaster;
    public event Action<Cube> CubeChosen;

    private void Awake()
    {
        _raycaster = GetComponent<Raycaster>();
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Cube cube = _raycaster.GetCube();
            CubeChosen(cube);
        }
    }
}