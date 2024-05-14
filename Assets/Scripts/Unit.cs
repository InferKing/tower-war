using UnityEngine;

public abstract class Unit : MonoBehaviour, IInitializable, IDisposable
{
    [SerializeField] private EarnConfig _earnConfig;
    public void Dispose()
    {
        
    }

    public void Initialize()
    {
        
    }
}
