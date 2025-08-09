using UnityEngine;

public class CubeChance : MonoBehaviour
{
    public float Chance => _chance;
    [SerializeField] private float _chance;


    public void UpdateChance(float chance)
    {
        _chance = chance;
    }
}
