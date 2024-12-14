using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthSmoothSlider : HealthValueView
{
    private Slider _slider;
    private Coroutine _coroutine;
    private float durationChangeHealth = 0.09f;

    private void Awake()
    {
        Init();
        _slider = GetComponent<Slider>();
        _slider.value = HealthValue;
    }

    protected override void SetCurrentHealthValue(float healthValue)
    {
        base.SetCurrentHealthValue(healthValue);
        _coroutine = StartCoroutine(SmoothChangeHealthValue(healthValue));
    }

    private IEnumerator SmoothChangeHealthValue(float healthValue)
    {
        while (_slider.value != healthValue)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, healthValue, durationChangeHealth);
            yield return null;
        }

        if(_slider.value != healthValue)
            yield break;
    }
}
