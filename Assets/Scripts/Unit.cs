using UnityEngine;

public abstract class Unit : MonoBehaviour, IInitializable, IDisposable, IHealth
{
    [SerializeField] private HealthConfig _health;
    public abstract int CurrentHealth { get; set; }
    public abstract int CurrentArmor { get; set; }

    public HealthConfig HealthConfig => _health;

    public void Dispose()
    {
        
    }

    public void Initialize()
    {
        
    }
}
