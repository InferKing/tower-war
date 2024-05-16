using UnityEngine;

[CreateAssetMenu(fileName = "MoneyConfig", menuName = "Config/MoneyConfig")]
public class MoneyConfig : ScriptableObject
{
    [field: SerializeField, Min(0)] public int Price { get; private set; }
    [field: SerializeField, Min(0)] public int KillingMoney { get; private set; }
}
