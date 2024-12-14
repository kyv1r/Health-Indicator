using UnityEngine;

public class HealthValueView : MonoBehaviour
{
    [SerializeField] protected HealthSystem HealthSystem;

    public float HealthValue {  get; private set; } 
    protected float MaxHealthValue { get; private set; }

    protected virtual void Awake()
    {
        HealthValue = HealthSystem.CurrentValue;
        MaxHealthValue = HealthSystem.MaxValue;
    }

    private void OnEnable()
    {
        HealthSystem.HealthChanged += SetCurrentHealthValue;
    }

    private void OnDisable()
    {
        HealthSystem.HealthChanged -= SetCurrentHealthValue;
    }

    protected virtual void SetCurrentHealthValue(float healthValue)
    {
        HealthValue = healthValue;
    }
}
