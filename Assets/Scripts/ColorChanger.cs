using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public void TryChangeColor()
    {
        ChangeColor();
    }
    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();

        renderer.material.color = Random.ColorHSV();
    }
}
