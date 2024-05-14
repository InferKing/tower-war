using UnityEngine;

[CreateAssetMenu(fileName = "CombatConfig", menuName = "Config/CombatConfig")]
public class CombatConfig : ScriptableObject
{
    [field: SerializeField] public AttackType AttackType { get; private set; }
    [field: SerializeField] public ArmorType ArmorType { get; private set; }
    [field: SerializeField] public AttackRange AttackRange { get; private set; }
}
