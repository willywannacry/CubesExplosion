using UnityEngine;

public class ChanceCounter : MonoBehaviour
{
    [SerializeField] private float _decreaseChance = 0.5f;

    public bool CountChance(float chance)
    {
        float roll = Random.Range(0f, 100f);
        Debug.Log($"ROLL: {roll} | CHANCE: {chance}");

        return roll < chance;
    }

    public void ChangeChance(GameObject[] cubes)
    {
        foreach (GameObject cube in cubes)
        {
            CubeChance cubeChance = cube.GetComponent<CubeChance>();

            if (cubeChance != null)
            {
                float newChance = cubeChance.Chance * _decreaseChance;
                cubeChance.UpdateChance(newChance);
            }
        }
    }
}
