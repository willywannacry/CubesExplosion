using UnityEngine;

public class ChanceCounter : MonoBehaviour
{
    private float _maxChance = 100f;
    private float _chance;
    private float _chanceDevider = 0.5f;
    public float ChanceDevider => _chanceDevider;
    private void Start()
    {
        if (_chance == 0)
        {
            _chance = _maxChance;
        }
    }

    public void CheckChance()
    {
        float roll = Random.Range(0, _maxChance);

        if (roll < _chance)
        {
            CubeDevider cubeDevider = GetComponent<CubeDevider>();
            cubeDevider.TrySplit();
            _chance *= _chanceDevider;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetChance(float chance)
    {
        _chance = chance;
    }

    public float GetChance()
    {
        return _chance;
    }
}
