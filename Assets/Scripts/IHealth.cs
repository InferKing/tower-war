public interface IHealth
{
    int CurrentHealth { get; set; }
    int CurrentArmor { get; set; }
    HealthConfig HealthConfig { get; }
}
