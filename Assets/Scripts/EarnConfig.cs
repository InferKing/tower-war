using UnityEngine;

[CreateAssetMenu(fileName = "EarnConfig", menuName = "Config/EarnConfig")]
public class EarnConfig : ScriptableObject
{
    [field: SerializeField, Min(0)] public int Price { get; private set; }
    [field: SerializeField, Min(0)] public int EarnedXP { get; private set; }
    [field: SerializeField, Min(0)] public int UnlockedXP { get; private set; }
}
