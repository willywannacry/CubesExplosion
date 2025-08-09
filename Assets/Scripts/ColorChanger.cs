using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    
    public void ChangeColor(GameObject[] cubes)
    {
        foreach (var cube in cubes)
        {
            Renderer renderer = cube.GetComponent<Renderer>();
            renderer.material.color = Random.ColorHSV();
        }
    }
}
