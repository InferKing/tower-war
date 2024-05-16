using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Unit : MonoBehaviour, IInitializable, IDisposable, IHealth
{
    [SerializeField] private HealthConfig _health;
    public abstract int CurrentHealth { get; set; }
    public abstract int CurrentArmor { get; set; }

    public HealthConfig HealthConfig => _health;

    public void Dispose()
    {
        throw new System.NotImplementedException();
    }

    public void Initialize()
    {
        throw new System.NotImplementedException();
    }
}
