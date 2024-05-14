using UnityEngine;

[CreateAssetMenu(fileName = "HealthConfig", menuName = "Config/HealthConfig")]
public class HealthConfig: ScriptableObject
{
    [field: SerializeField] public int MaxHealth { get; private set; }
    [field: SerializeField] public int Armor { get; private set; }
}
