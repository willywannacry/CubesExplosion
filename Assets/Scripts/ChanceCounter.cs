using UnityEngine;

public class ChanceCounter : MonoBehaviour
{
    private float _minChance = 0;
    private float _maxChance = 100;
    private float _decrement = 0.5f;

    public bool Roll(float chance)
    {
        float roll = Random.Range(_minChance, _maxChance);
        Debug.Log($"{roll} < {chance}");
        return roll < chance;
    }
    public float NewChance(Cube cube)
    {
        return cube.Chance * _decrement;
    }
}
