public interface IAttacker
{
    int CurrentDamage { get; set; }
    void ApplyDamage(IHealth health);
    CombatConfig CombatConfig { get; }
}
