using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSliderView : HealthValueView
{
    private Slider _slider;

    private void Awake()
    {
        Init();
        _slider = GetComponent<Slider>();
        _slider.value = HealthValue;
    }

    protected override void SetCurrentHealthValue(float healthValue)
    {
        base.SetCurrentHealthValue(healthValue);
        _slider.value = HealthValue;

    }
}
