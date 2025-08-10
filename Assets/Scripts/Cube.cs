using UnityEngine;

[RequireComponent(typeof(ColorChanger))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Renderer))]
public class Cube : MonoBehaviour
{
    [SerializeField] private float _chance;

    public Rigidbody Rb => _rb;
    public float Chance => _chance;

    private ColorChanger _changer;
    private Renderer _renderer;
    private Rigidbody _rb;

    public void Init(Vector3 scale, float chance, float multiplier)
    {
        transform.localScale = scale * multiplier;
        _chance = chance;
    }

    private void Awake()
    {
        _changer = GetComponent<ColorChanger>();
        _renderer = GetComponent<Renderer>();
        _changer.ChangeColor(_renderer);
        _rb = GetComponent<Rigidbody>();
    }
}
