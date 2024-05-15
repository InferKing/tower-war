using UnityEngine;

[CreateAssetMenu(fileName = "HealthConfig", menuName = "Config/HealthConfig")]
public class HealthConfig: ScriptableObject
{
    [field: SerializeField] public int BaseMaxHealth { get; private set; }
    [field: SerializeField] public int BaseArmor { get; private set; }
}
