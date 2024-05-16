using UnityEngine;

[CreateAssetMenu(fileName = "XPConfig", menuName = "Config/XPConfig")]
public class XPConfig : ScriptableObject
{
    [field: SerializeField, Min(0)] public int EarnedXP { get; private set; }
    [field: SerializeField, Min(0)] public int UnlockedXP { get; private set; }
}
