public interface IHealth
{
    int CurrentHealth { get; protected set; }
    HealthConfig HealthConfig { get; protected set; }
}
