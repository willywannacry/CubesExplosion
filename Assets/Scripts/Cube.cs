using UnityEngine;

public class Cube : MonoBehaviour
{
    private ColorChanger _changer;

    public Cube(float chance)
    {
        Chance = chance;
    }

    private void Start()
    {
        if (Chance == 0)
        {
            UpdateChance(100);
        }
    }

    
    public float Chance { get; private set; }

    private void Awake()
    {
        _changer = gameObject.GetComponent<ColorChanger>();
        _changer.ChangeColor();
    }

    public void UpdateChance(float chance)
    {
        Chance = chance;
    }
}
