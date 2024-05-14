using UnityEngine;

[System.Serializable]
public class AttackRange
{
    [field: SerializeField] public int MinDamage { get; private set; }
    [field: SerializeField] public int MaxDamage { get; private set; }

}
