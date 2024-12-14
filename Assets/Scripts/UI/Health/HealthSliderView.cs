using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSliderView : HealthValueView
{
    private Slider _slider;

    protected override void Awake()
    {
        base.Awake();
        _slider = GetComponent<Slider>();
        _slider.value = HealthValue;
    }

    protected override void SetCurrentHealthValue(float healthValue)
    {
        base.SetCurrentHealthValue(healthValue);
        _slider.value = HealthValue;

    }
}
